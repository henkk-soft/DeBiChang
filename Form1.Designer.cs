
namespace LOL_Little_Book
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.ComboBox();
            this.team = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hero = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "游戏状态：";
            // 
            // action
            // 
            this.action.FormattingEnabled = true;
            this.action.Location = new System.Drawing.Point(485, 20);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(221, 164);
            this.action.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "作为";
            // 
            // name
            // 
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(28, 102);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(169, 23);
            this.name.TabIndex = 4;
            this.name.SelectedIndexChanged += new System.EventHandler(this.name_SelectedIndexChanged);
            // 
            // team
            // 
            this.team.AutoSize = true;
            this.team.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.team.Location = new System.Drawing.Point(262, 105);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(52, 15);
            this.team.TabIndex = 5;
            this.team.Text = "猪队友";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.ForeColor = System.Drawing.Color.Tomato;
            this.state.Location = new System.Drawing.Point(123, 20);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(52, 15);
            this.state.TabIndex = 6;
            this.state.Text = "未进行";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "玩";
            // 
            // hero
            // 
            this.hero.AutoSize = true;
            this.hero.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hero.Location = new System.Drawing.Point(359, 105);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(0, 15);
            this.hero.TabIndex = 8;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(76, 225);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.info.Size = new System.Drawing.Size(630, 128);
            this.info.TabIndex = 9;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(239, 161);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(137, 41);
            this.add.TabIndex = 10;
            this.add.Text = "添加";
            this.add.UseCompatibleTextRendering = true;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 365);
            this.Controls.Add(this.add);
            this.Controls.Add(this.info);
            this.Controls.Add(this.hero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.state);
            this.Controls.Add(this.team);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.action);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LOL Little Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox action;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.Label team;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label hero;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Button add;
    }
}

