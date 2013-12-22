namespace Recipe_Calculator
{
    partial class Form1
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
            this.ingredientList = new System.Windows.Forms.TextBox();
            this.ingredients = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ingredientsPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.newAmountText = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.portionsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.newPortions = new System.Windows.Forms.TextBox();
            this.originalPortions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioPortion = new System.Windows.Forms.RadioButton();
            this.radioIngredient = new System.Windows.Forms.RadioButton();
            this.calculateBt = new System.Windows.Forms.Button();
            this.updateBt = new System.Windows.Forms.Button();
            this.cleanBt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ingredientsPanel.SuspendLayout();
            this.portionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ingredientList
            // 
            this.ingredientList.Location = new System.Drawing.Point(12, 50);
            this.ingredientList.Multiline = true;
            this.ingredientList.Name = "ingredientList";
            this.ingredientList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ingredientList.Size = new System.Drawing.Size(388, 140);
            this.ingredientList.TabIndex = 0;
            // 
            // ingredients
            // 
            this.ingredients.AutoSize = true;
            this.ingredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredients.Location = new System.Drawing.Point(97, 21);
            this.ingredients.Name = "ingredients";
            this.ingredients.Size = new System.Drawing.Size(213, 26);
            this.ingredients.TabIndex = 1;
            this.ingredients.Text = "Lista de Ingredientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ingredientsPanel);
            this.groupBox1.Controls.Add(this.portionsPanel);
            this.groupBox1.Controls.Add(this.radioPortion);
            this.groupBox1.Controls.Add(this.radioIngredient);
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // ingredientsPanel
            // 
            this.ingredientsPanel.Controls.Add(this.label3);
            this.ingredientsPanel.Controls.Add(this.newAmountText);
            this.ingredientsPanel.Controls.Add(this.comboBox1);
            this.ingredientsPanel.Location = new System.Drawing.Point(119, 14);
            this.ingredientsPanel.Name = "ingredientsPanel";
            this.ingredientsPanel.Size = new System.Drawing.Size(253, 39);
            this.ingredientsPanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade pretendida";
            // 
            // newAmountText
            // 
            this.newAmountText.Location = new System.Drawing.Point(168, 0);
            this.newAmountText.Name = "newAmountText";
            this.newAmountText.Size = new System.Drawing.Size(40, 20);
            this.newAmountText.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // portionsPanel
            // 
            this.portionsPanel.Controls.Add(this.label2);
            this.portionsPanel.Controls.Add(this.newPortions);
            this.portionsPanel.Controls.Add(this.originalPortions);
            this.portionsPanel.Controls.Add(this.label1);
            this.portionsPanel.Location = new System.Drawing.Point(119, 62);
            this.portionsPanel.Name = "portionsPanel";
            this.portionsPanel.Size = new System.Drawing.Size(253, 39);
            this.portionsPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade pretendida";
            // 
            // newPortions
            // 
            this.newPortions.Location = new System.Drawing.Point(168, 3);
            this.newPortions.Name = "newPortions";
            this.newPortions.Size = new System.Drawing.Size(40, 20);
            this.newPortions.TabIndex = 3;
            // 
            // originalPortions
            // 
            this.originalPortions.Location = new System.Drawing.Point(44, 3);
            this.originalPortions.MaxLength = 4;
            this.originalPortions.Name = "originalPortions";
            this.originalPortions.Size = new System.Drawing.Size(40, 20);
            this.originalPortions.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade da receita";
            // 
            // radioPortion
            // 
            this.radioPortion.AutoSize = true;
            this.radioPortion.Location = new System.Drawing.Point(7, 68);
            this.radioPortion.Name = "radioPortion";
            this.radioPortion.Size = new System.Drawing.Size(91, 17);
            this.radioPortion.TabIndex = 1;
            this.radioPortion.TabStop = true;
            this.radioPortion.Text = "Alterar porção";
            this.radioPortion.UseVisualStyleBackColor = true;
            this.radioPortion.CheckedChanged += new System.EventHandler(this.radioPortion_CheckedChanged);
            // 
            // radioIngredient
            // 
            this.radioIngredient.AutoSize = true;
            this.radioIngredient.Location = new System.Drawing.Point(7, 20);
            this.radioIngredient.Name = "radioIngredient";
            this.radioIngredient.Size = new System.Drawing.Size(110, 17);
            this.radioIngredient.TabIndex = 0;
            this.radioIngredient.TabStop = true;
            this.radioIngredient.Text = "Alterar ingrediente";
            this.radioIngredient.UseVisualStyleBackColor = true;
            this.radioIngredient.CheckedChanged += new System.EventHandler(this.radioIngredient_CheckedChanged);
            // 
            // calculateBt
            // 
            this.calculateBt.Location = new System.Drawing.Point(150, 364);
            this.calculateBt.Name = "calculateBt";
            this.calculateBt.Size = new System.Drawing.Size(116, 23);
            this.calculateBt.TabIndex = 3;
            this.calculateBt.Text = "Calcular";
            this.calculateBt.UseVisualStyleBackColor = true;
            this.calculateBt.Click += new System.EventHandler(this.calculateBt_Click);
            // 
            // updateBt
            // 
            this.updateBt.Location = new System.Drawing.Point(284, 364);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(116, 23);
            this.updateBt.TabIndex = 4;
            this.updateBt.Text = "Actualizar";
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.update_Click);
            // 
            // cleanBt
            // 
            this.cleanBt.Location = new System.Drawing.Point(12, 364);
            this.cleanBt.Name = "cleanBt";
            this.cleanBt.Size = new System.Drawing.Size(116, 23);
            this.cleanBt.TabIndex = 5;
            this.cleanBt.Text = "Limpar";
            this.cleanBt.UseVisualStyleBackColor = true;
            this.cleanBt.Click += new System.EventHandler(this.clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 422);
            this.Controls.Add(this.cleanBt);
            this.Controls.Add(this.updateBt);
            this.Controls.Add(this.calculateBt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ingredients);
            this.Controls.Add(this.ingredientList);
            this.Name = "Form1";
            this.Text = "Recipe Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ingredientsPanel.ResumeLayout(false);
            this.ingredientsPanel.PerformLayout();
            this.portionsPanel.ResumeLayout(false);
            this.portionsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ingredientList;
        private System.Windows.Forms.Label ingredients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox originalPortions;
        private System.Windows.Forms.RadioButton radioPortion;
        private System.Windows.Forms.RadioButton radioIngredient;
        private System.Windows.Forms.Panel portionsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPortions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateBt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel ingredientsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newAmountText;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.Button cleanBt;
    }
}

