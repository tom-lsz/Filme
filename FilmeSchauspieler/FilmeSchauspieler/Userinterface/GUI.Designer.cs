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
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 524);
            this.Controls.Add(this.lb_countprop);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lib_properly);
            this.Controls.Add(this.lib_all);
            this.Controls.Add(this.lb_countall);
            this.Controls.Add(this.cmb_select);
            this.Name = "GUI";
            this.Text = "GUI";
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
    }
}

