using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace AutoClicker
{
  class Clicker
  {
    // http://d.hatena.ne.jp/tmurata/20110217/1297947373 こちらを参照いたしました

    // マウス関連Win32API
    [DllImport("user32.dll")]
    extern static uint SendInput(
        uint nInputs,     // 構造体の数(イベント数)
        INPUT[] pInputs,  // 構造体
        int cbSize        // 構造体のサイズ
        );

    // アンマネージ DLL 対応用 struct 記述宣言
    // Note: struct の場合、デフォルト(パラメータなしの)コンストラクタは、
    //       言語側で定義済みで、フィールドを 0 に初期化する。
    [StructLayout(LayoutKind.Sequential)]
    struct INPUT
    {
      public int type;        // 0 = INPUT_MOUSE(デフォルト), 1 = INPUT_KEYBOARD
      public MOUSEINPUT mi;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct MOUSEINPUT
    {
      public int dx;
      public int dy;
      public int mouseData;
      public int dwFlags;
      public int time;
      public IntPtr dwExtraInfo;
    }

    // dwFlags
    const int MOUSEEVENTF_MOVED = 0x0001;
    const int MOUSEEVENTF_LEFTDOWN = 0x0002;  // 左ボタン Down
    const int MOUSEEVENTF_LEFTUP = 0x0004;    // 左ボタン Up
    const int MOUSEEVENTF_RIGHTDOWN = 0x0008; // 右ボタン Down
    const int MOUSEEVENTF_RIGHTUP = 0x0010;   // 右ボタン Up
    const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;// 中ボタン Down
    const int MOUSEEVENTF_MIDDLEUP = 0x0040;  // 中ボタン Up
    const int MOUSEEVENTF_WHEEL = 0x0080;
    const int MOUSEEVENTF_XDOWN = 0x0100;
    const int MOUSEEVENTF_XUP = 0x0200;
    const int MOUSEEVENTF_ABSOLUTE = 0x8000;

    const int screen_length = 0x10000;  // for MOUSEEVENTF_ABSOLUTE (この値は固定)

    /// <summary>
    /// 指定した位置をクリックする
    /// </summary>
    /// <param name="targetX">クリック先X座標</param>
    /// <param name="targetY">クリック先Y座標</param>
    public void sendClick(int targetX, int targetY)
    {
      // クリック元の取得
      int fromX = Cursor.Position.X;
      int fromY = Cursor.Position.Y;

      // クリック先へ移動
      Cursor.Position = new Point(targetX, targetY);

      // struct 配列の宣言
      INPUT[] input = new INPUT[2];
      input[0].mi.dwFlags = MOUSEEVENTF_LEFTDOWN; // 左ボタンDown
      input[1].mi.dwFlags = MOUSEEVENTF_LEFTUP;   // 左ボタンUp

      // イベントの一括生成
      SendInput(2, input, Marshal.SizeOf(input[0]));

      // クリック元へ移動
      Cursor.Position = new Point(fromX, fromY);
    }
  }
}
