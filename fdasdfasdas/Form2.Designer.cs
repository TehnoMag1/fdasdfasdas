namespace fdasdfasdas
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            товарToolStripMenuItem = new ToolStripMenuItem();
            клиентToolStripMenuItem = new ToolStripMenuItem();
            заказToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { товарToolStripMenuItem, клиентToolStripMenuItem, заказToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // товарToolStripMenuItem
            // 
            товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            товарToolStripMenuItem.Size = new Size(50, 20);
            товарToolStripMenuItem.Text = "товар";
            товарToolStripMenuItem.Click += товарToolStripMenuItem_Click;
            // 
            // клиентToolStripMenuItem
            // 
            клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            клиентToolStripMenuItem.Size = new Size(57, 20);
            клиентToolStripMenuItem.Text = "клиент";
            клиентToolStripMenuItem.Click += клиентToolStripMenuItem_Click;
            // 
            // заказToolStripMenuItem
            // 
            заказToolStripMenuItem.Name = "заказToolStripMenuItem";
            заказToolStripMenuItem.Size = new Size(47, 20);
            заказToolStripMenuItem.Text = "заказ";
            заказToolStripMenuItem.Click += заказToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem товарToolStripMenuItem;
        private ToolStripMenuItem клиентToolStripMenuItem;
        private ToolStripMenuItem заказToolStripMenuItem;
    }
}