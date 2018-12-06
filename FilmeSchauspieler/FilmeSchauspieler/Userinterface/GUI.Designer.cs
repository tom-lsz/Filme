namespace FilmeSchauspieler.Userinterface
{
    partial class GUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_select = new System.Windows.Forms.ComboBox();
            this.lb_countall = new System.Windows.Forms.Label();
            this.lib_all = new System.Windows.Forms.ListBox();
            this.lib_properly = new System.Windows.Forms.ListBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lb_countprop = new System.Windows.Forms.Label();
            this.pl_create = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.lb_electedrecords = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_addelectedrecord = new System.Windows.Forms.Button();
            this.lib_electedrecords = new System.Windows.Forms.ListBox();
            this.lib_existingrecords = new System.Windows.Forms.ListBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_addentry = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_newrecord = new System.Windows.Forms.Label();
            this.cmb_newrecord = new System.Windows.Forms.ComboBox();
            this.pl_create.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_select
            // 
            this.cmb_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmb_select.FormattingEnabled = true;
            this.cmb_select.Location = new System.Drawing.Point(13, 27);
            this.cmb_select.Name = "cmb_select";
            this.cmb_select.Size = new System.Drawing.Size(760, 33);
            this.cmb_select.TabIndex = 0;
            this.cmb_select.SelectedValueChanged += new System.EventHandler(this.cmb_select_SelectedValueChanged);
            // 
            // lb_countall
            // 
            this.lb_countall.AutoSize = true;
            this.lb_countall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_countall.Location = new System.Drawing.Point(15, 74);
            this.lb_countall.Name = "lb_countall";
            this.lb_countall.Size = new System.Drawing.Size(0, 17);
            this.lb_countall.TabIndex = 2;
            // 
            // lib_all
            // 
            this.lib_all.FormattingEnabled = true;
            this.lib_all.Location = new System.Drawing.Point(18, 94);
            this.lib_all.Name = "lib_all";
            this.lib_all.Size = new System.Drawing.Size(755, 147);
            this.lib_all.TabIndex = 3;
            this.lib_all.SelectedIndexChanged += new System.EventHandler(this.lib_all_SelectedIndexChanged);
            // 
            // lib_properly
            // 
            this.lib_properly.FormattingEnabled = true;
            this.lib_properly.Location = new System.Drawing.Point(18, 284);
            this.lib_properly.Name = "lib_properly";
            this.lib_properly.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lib_properly.Size = new System.Drawing.Size(755, 147);
            this.lib_properly.TabIndex = 4;
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_create.Location = new System.Drawing.Point(15, 450);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(231, 62);
            this.btn_create.TabIndex = 5;
            this.btn_create.Text = "Anlegen";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_edit.Location = new System.Drawing.Point(530, 450);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(231, 62);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Bearbeiten";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // lb_countprop
            // 
            this.lb_countprop.AutoSize = true;
            this.lb_countprop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_countprop.Location = new System.Drawing.Point(15, 254);
            this.lb_countprop.Name = "lb_countprop";
            this.lb_countprop.Size = new System.Drawing.Size(0, 17);
            this.lb_countprop.TabIndex = 8;
            // 
            // pl_create
            // 
            this.pl_create.Controls.Add(this.btn_menu);
            this.pl_create.Controls.Add(this.lb_electedrecords);
            this.pl_create.Controls.Add(this.btn_save);
            this.pl_create.Controls.Add(this.btn_addelectedrecord);
            this.pl_create.Controls.Add(this.lib_electedrecords);
            this.pl_create.Controls.Add(this.lib_existingrecords);
            this.pl_create.Controls.Add(this.tb_name);
            this.pl_create.Controls.Add(this.lb_addentry);
            this.pl_create.Controls.Add(this.lb_name);
            this.pl_create.Controls.Add(this.lb_newrecord);
            this.pl_create.Controls.Add(this.cmb_newrecord);
            this.pl_create.Location = new System.Drawing.Point(13, 12);
            this.pl_create.Name = "pl_create";
            this.pl_create.Size = new System.Drawing.Size(781, 500);
            this.pl_create.TabIndex = 9;
            this.pl_create.Visible = false;
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_menu.Location = new System.Drawing.Point(517, 413);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(231, 62);
            this.btn_menu.TabIndex = 10;
            this.btn_menu.Text = "Hauptmenü";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // lb_electedrecords
            // 
            this.lb_electedrecords.AutoSize = true;
            this.lb_electedrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_electedrecords.Location = new System.Drawing.Point(474, 129);
            this.lb_electedrecords.Name = "lb_electedrecords";
            this.lb_electedrecords.Size = new System.Drawing.Size(96, 16);
            this.lb_electedrecords.TabIndex = 9;
            this.lb_electedrecords.Text = "ausgewählte ...";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_save.Location = new System.Drawing.Point(55, 413);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(231, 62);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_addelectedrecord
            // 
            this.btn_addelectedrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addelectedrecord.Location = new System.Drawing.Point(325, 246);
            this.btn_addelectedrecord.Name = "btn_addelectedrecord";
            this.btn_addelectedrecord.Size = new System.Drawing.Size(146, 38);
            this.btn_addelectedrecord.TabIndex = 7;
            this.btn_addelectedrecord.Text = "Hinzufügen";
            this.btn_addelectedrecord.UseVisualStyleBackColor = true;
            this.btn_addelectedrecord.Click += new System.EventHandler(this.btn_addelectedrecord_Click);
            // 
            // lib_electedrecords
            // 
            this.lib_electedrecords.FormattingEnabled = true;
            this.lib_electedrecords.Location = new System.Drawing.Point(477, 155);
            this.lib_electedrecords.Name = "lib_electedrecords";
            this.lib_electedrecords.Size = new System.Drawing.Size(301, 238);
            this.lib_electedrecords.TabIndex = 6;
            // 
            // lib_existingrecords
            // 
            this.lib_existingrecords.FormattingEnabled = true;
            this.lib_existingrecords.Location = new System.Drawing.Point(18, 155);
            this.lib_existingrecords.Name = "lib_existingrecords";
            this.lib_existingrecords.Size = new System.Drawing.Size(301, 238);
            this.lib_existingrecords.TabIndex = 5;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(215, 62);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(334, 22);
            this.tb_name.TabIndex = 4;
            // 
            // lb_addentry
            // 
            this.lb_addentry.AutoSize = true;
            this.lb_addentry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_addentry.Location = new System.Drawing.Point(15, 129);
            this.lb_addentry.Name = "lb_addentry";
            this.lb_addentry.Size = new System.Drawing.Size(92, 16);
            this.lb_addentry.TabIndex = 3;
            this.lb_addentry.Text = "vorhandene ...";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(15, 63);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(48, 16);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Name:";
            // 
            // lb_newrecord
            // 
            this.lb_newrecord.AutoSize = true;
            this.lb_newrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_newrecord.Location = new System.Drawing.Point(15, 26);
            this.lb_newrecord.Name = "lb_newrecord";
            this.lb_newrecord.Size = new System.Drawing.Size(183, 16);
            this.lb_newrecord.TabIndex = 1;
            this.lb_newrecord.Text = "Neuen Datensatz anlegen für:";
            // 
            // cmb_newrecord
            // 
            this.cmb_newrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_newrecord.FormattingEnabled = true;
            this.cmb_newrecord.Location = new System.Drawing.Point(215, 23);
            this.cmb_newrecord.Name = "cmb_newrecord";
            this.cmb_newrecord.Size = new System.Drawing.Size(334, 24);
            this.cmb_newrecord.TabIndex = 0;
            this.cmb_newrecord.SelectedIndexChanged += new System.EventHandler(this.cmb_newrecord_SelectedValueChanged);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 524);
            this.Controls.Add(this.pl_create);
            this.Controls.Add(this.lb_countprop);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lib_properly);
            this.Controls.Add(this.lib_all);
            this.Controls.Add(this.lb_countall);
            this.Controls.Add(this.cmb_select);
            this.Name = "GUI";
            this.Text = "GUI";
            this.pl_create.ResumeLayout(false);
            this.pl_create.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_select;
        private System.Windows.Forms.Label lb_countall;
        private System.Windows.Forms.ListBox lib_all;
        private System.Windows.Forms.ListBox lib_properly;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lb_countprop;
        private System.Windows.Forms.Panel pl_create;
        private System.Windows.Forms.Button btn_addelectedrecord;
        private System.Windows.Forms.ListBox lib_electedrecords;
        private System.Windows.Forms.ListBox lib_existingrecords;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_addentry;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_newrecord;
        private System.Windows.Forms.ComboBox cmb_newrecord;
        private System.Windows.Forms.Label lb_electedrecords;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_menu;
    }
}

