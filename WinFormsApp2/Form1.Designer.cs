namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_players = new DataGridView();
            lbl_id = new Label();
            lbl_name = new Label();
            lbl_position = new Label();
            lbl_team = new Label();
            txt_id = new TextBox();
            txt_name = new TextBox();
            txt_position = new TextBox();
            ComboBox_team = new ComboBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_players).BeginInit();
            SuspendLayout();
            // 
            // dgv_players
            // 
            dgv_players.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_players.Location = new Point(12, 361);
            dgv_players.Name = "dgv_players";
            dgv_players.RowHeadersWidth = 51;
            dgv_players.RowTemplate.Height = 29;
            dgv_players.Size = new Size(598, 280);
            dgv_players.TabIndex = 0;
            dgv_players.RowHeaderMouseDoubleClick += dgv_players_RowHeaderMouseDoubleClick;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(29, 21);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(24, 20);
            lbl_id.TabIndex = 1;
            lbl_id.Text = "ID";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(231, 21);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(49, 20);
            lbl_name.TabIndex = 2;
            lbl_name.Text = "Name";
            lbl_name.Click += lbl_name_Click;
            // 
            // lbl_position
            // 
            lbl_position.AutoSize = true;
            lbl_position.Location = new Point(453, 27);
            lbl_position.Name = "lbl_position";
            lbl_position.Size = new Size(61, 20);
            lbl_position.TabIndex = 3;
            lbl_position.Text = "Position";
            lbl_position.Click += lbl_position_Click;
            // 
            // lbl_team
            // 
            lbl_team.AutoSize = true;
            lbl_team.Location = new Point(719, 26);
            lbl_team.Name = "lbl_team";
            lbl_team.Size = new Size(45, 20);
            lbl_team.TabIndex = 4;
            lbl_team.Text = "Team";
            lbl_team.Click += lbl_team_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(77, 24);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(125, 27);
            txt_id.TabIndex = 5;
            txt_id.TextChanged += txt_id_TextChanged;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(286, 24);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 6;
            txt_name.TextChanged += txt_name_TextChanged;
            // 
            // txt_position
            // 
            txt_position.Location = new Point(520, 23);
            txt_position.Name = "txt_position";
            txt_position.Size = new Size(125, 27);
            txt_position.TabIndex = 7;
            // 
            // ComboBox_team
            // 
            ComboBox_team.FormattingEnabled = true;
            ComboBox_team.Location = new Point(770, 24);
            ComboBox_team.Name = "ComboBox_team";
            ComboBox_team.Size = new Size(151, 28);
            ComboBox_team.TabIndex = 8;
            ComboBox_team.SelectedIndexChanged += ComboBox_team_SelectedIndexChanged;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(186, 146);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 9;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(407, 146);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 10;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(606, 146);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_epic_soccer_background_indoor_soccer;
            ClientSize = new Size(1057, 653);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(ComboBox_team);
            Controls.Add(txt_position);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(lbl_team);
            Controls.Add(lbl_position);
            Controls.Add(lbl_name);
            Controls.Add(lbl_id);
            Controls.Add(dgv_players);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_players).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_players;
        private Label lbl_id;
        private Label lbl_name;
        private Label lbl_position;
        private Label lbl_team;
        private TextBox txt_id;
        private TextBox txt_name;
        private TextBox txt_position;
        private ComboBox ComboBox_team;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
    }
}