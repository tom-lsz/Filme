namespace FilmeSchauspieler
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
            this.bt_confirm = new System.Windows.Forms.Button();
            this.lb_count = new System.Windows.Forms.Label();
            this.lib_all = new System.Windows.Forms.ListBox();
            this.lib_properly = new System.Windows.Forms.ListBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_select
            // 
            this.cmb_select.FormattingEnabled = true;
            this.cmb_select.Location = new System.Drawing.Point(13, 27);
            this.cmb_select.Name = "cmb_select";
            this.cmb_select.Size = new System.Drawing.Size(121, 21);
            this.cmb_select.TabIndex = 0;
            // 
            // bt_confirm
            // 
            this.bt_confirm.Location = new System.Drawing.Point(197, 25);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(75, 23);
            this.bt_confirm.TabIndex = 1;
            this.bt_confirm.Text = "Bestätigen";
            this.bt_confirm.UseVisualStyleBackColor = true;
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(12, 91);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(150, 13);
            this.lb_count.TabIndex = 2;
            this.lb_count.Text = "Anzahl der Filme/Schauspieler";
            // 
            // lib_all
            // 
            this.lib_all.FormattingEnabled = true;
            this.lib_all.Location = new System.Drawing.Point(15, 121);
            this.lib_all.Name = "lib_all";
            this.lib_all.Size = new System.Drawing.Size(191, 277);
            this.lib_all.TabIndex = 3;
            // 
            // lib_properly
            // 
            this.lib_properly.FormattingEnabled = true;
            this.lib_properly.Location = new System.Drawing.Point(237, 121);
            this.lib_properly.Name = "lib_properly";
            this.lib_properly.Size = new System.Drawing.Size(191, 277);
            this.lib_properly.TabIndex = 4;
            // 
            // btn_apply
            // 
            this.btn_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_apply.Location = new System.Drawing.Point(479, 121);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(281, 65);
            this.btn_apply.TabIndex = 5;
            this.btn_apply.Text = "Anlegen";
            this.btn_apply.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_delete.Location = new System.Drawing.Point(479, 333);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(281, 65);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_edit.Location = new System.Drawing.Point(479, 228);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(281, 65);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Bearbeiten";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 524);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.lib_properly);
            this.Controls.Add(this.lib_all);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.bt_confirm);
            this.Controls.Add(this.cmb_select);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_select;
        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.ListBox lib_all;
        private System.Windows.Forms.ListBox lib_properly;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
    }
}

