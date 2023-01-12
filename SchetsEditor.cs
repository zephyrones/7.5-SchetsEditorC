using System;
using System.Drawing;
using System.Windows.Forms;

public class SchetsEditor : Form
{
    private MenuStrip menuStrip;

    public SchetsEditor()
    {   
        this.ClientSize = new Size(800, 600);
        menuStrip = new MenuStrip();
        this.Controls.Add(menuStrip);
        this.maakFileMenu();
        this.maakHelpMenu();
        this.Text = "Schets editor";
        this.IsMdiContainer = true;
        this.MainMenuStrip = menuStrip;
    }
    private void maakFileMenu()
    {   
        ToolStripDropDownItem menu = new ToolStripMenuItem("File");
        menu.DropDownItems.Add("Nieuw", null, this.nieuw);
        menu.DropDownItems.Add("Exit", null, this.afsluiten);
       // menu.DropDownItems.Add("Exporteren", this.export);
        menuStrip.Items.Add(menu);
    }
    private void maakHelpMenu()
    {   
        ToolStripDropDownItem menu = new ToolStripMenuItem("Help");
        menu.DropDownItems.Add("Over \"Schets\"", null, this.about);
        menuStrip.Items.Add(menu);
    }
    private void about(object o, EventArgs ea)
    {   
        MessageBox.Show ( "Schets versie 2.0\n(c) UU Informatica 2022"
                        , "Over \"Schets\""
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information
                        );
    }

    private void nieuw(object sender, EventArgs e)
    {   
        SchetsWin s = new SchetsWin();
        s.MdiParent = this;
        s.Show();
    }
    private void afsluiten(object sender, EventArgs e)
    {   
        this.Close();
    }
    /*
    private void export(object sender, EventArgs e)
    {
       
    }
    */

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // SchetsEditor
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "SchetsEditor";
            this.Load += new System.EventHandler(this.SchetsEditor_Load);
            this.ResumeLayout(false);

    }

    private void SchetsEditor_Load(object sender, EventArgs e)
    {

    }
}