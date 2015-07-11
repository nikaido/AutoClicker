using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
  public partial class frmMain : Form
  {
    private Clicker clicker;
    private DateTime dt;
    private String prevTime = "";


    const String PROGRAM_NAME = "AutoClicker";

    

    public frmMain()
    {
      InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      setWindowTitle();
      clicker = new Clicker();

    }

    private void timer_Tick(object sender, EventArgs e)
    {
      setWindowTitle();
    }

    private void setWindowTitle()
    {
      // Cursor Position
      this.Text = PROGRAM_NAME +" | " + Cursor.Position.X + "," + Cursor.Position.Y;

      // Now
      dt = DateTime.Now;

      String currentTime = dt.ToString("HH:mm:ss");
      if (prevTime != currentTime)
      {
        // 秒単位で発生するイベント
        prevTime = currentTime;
        statusTime.Text = currentTime;

        if (chkEnabled.CheckState == CheckState.Checked)
        {
          int x = (int)numPosX.Value;
          int y = (int)numPosY.Value;
          clicker.sendClick(x, y);
        }
      }
    }
  }
}
