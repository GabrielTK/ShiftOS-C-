﻿using System;

namespace ShiftOS
{
    partial class KnowledgeInput
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

        //Required by the Windows Form Designer

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnowledgeInput));
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.pnlintro = new System.Windows.Forms.Panel();
            this.pnlcategorydisplay = new System.Windows.Forms.Panel();
            this.lblnextreward = new System.Windows.Forms.Label();
            this.guessbox = new System.Windows.Forms.TextBox();
            this.lblcurrentlevel = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.listblistedstuff = new System.Windows.Forms.ListBox();
            this.lbltillnextlevel = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.lblcatedescription = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.decider = new System.Windows.Forms.Timer(this.components);
            this.Label6 = new System.Windows.Forms.Label();
            this.pgcontents = new System.Windows.Forms.Panel();
            this.tmrstoryline = new System.Windows.Forms.Timer(this.components);
            this.pnlintro.SuspendLayout();
            this.pnlcategorydisplay.SuspendLayout();
            this.pgcontents.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox1.BackColor = System.Drawing.Color.White;
            this.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox1.ForeColor = System.Drawing.Color.Black;
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 24;
            this.ListBox1.Items.AddRange(new object[] {
            "Animals",
            "Countries",
            "Fruits"});
            this.ListBox1.Location = new System.Drawing.Point(9, 49);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(179, 240);
            this.ListBox1.TabIndex = 0;
            this.ListBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox1_DrawItem);
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // pnlintro
            // 
            this.pnlintro.Controls.Add(this.pnlcategorydisplay);
            this.pnlintro.Controls.Add(this.Label4);
            this.pnlintro.Controls.Add(this.Label3);
            this.pnlintro.Controls.Add(this.Label2);
            this.pnlintro.Controls.Add(this.Label1);
            this.pnlintro.Location = new System.Drawing.Point(190, 0);
            this.pnlintro.Name = "pnlintro";
            this.pnlintro.Size = new System.Drawing.Size(479, 272);
            this.pnlintro.TabIndex = 1;
            // 
            // pnlcategorydisplay
            // 
            this.pnlcategorydisplay.Controls.Add(this.lblnextreward);
            this.pnlcategorydisplay.Controls.Add(this.guessbox);
            this.pnlcategorydisplay.Controls.Add(this.lblcurrentlevel);
            this.pnlcategorydisplay.Controls.Add(this.Label5);
            this.pnlcategorydisplay.Controls.Add(this.listblistedstuff);
            this.pnlcategorydisplay.Controls.Add(this.lbltillnextlevel);
            this.pnlcategorydisplay.Controls.Add(this.lbltotal);
            this.pnlcategorydisplay.Controls.Add(this.btnstart);
            this.pnlcategorydisplay.Controls.Add(this.lblcatedescription);
            this.pnlcategorydisplay.Controls.Add(this.lblcategory);
            this.pnlcategorydisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcategorydisplay.ForeColor = System.Drawing.Color.Black;
            this.pnlcategorydisplay.Location = new System.Drawing.Point(0, 0);
            this.pnlcategorydisplay.Name = "pnlcategorydisplay";
            this.pnlcategorydisplay.Size = new System.Drawing.Size(479, 272);
            this.pnlcategorydisplay.TabIndex = 2;
            // 
            // lblnextreward
            // 
            this.lblnextreward.AutoSize = true;
            this.lblnextreward.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnextreward.Location = new System.Drawing.Point(36, 110);
            this.lblnextreward.Name = "lblnextreward";
            this.lblnextreward.Size = new System.Drawing.Size(244, 20);
            this.lblnextreward.TabIndex = 11;
            this.lblnextreward.Text = "Reward for completing level 1: 5CP";
            this.lblnextreward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessbox
            // 
            this.guessbox.BackColor = System.Drawing.Color.White;
            this.guessbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guessbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessbox.ForeColor = System.Drawing.Color.Black;
            this.guessbox.Location = new System.Drawing.Point(11, 147);
            this.guessbox.Multiline = true;
            this.guessbox.Name = "guessbox";
            this.guessbox.Size = new System.Drawing.Size(297, 45);
            this.guessbox.TabIndex = 9;
            this.guessbox.Text = "Enter Guess Here";
            this.guessbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guessbox.Click += new System.EventHandler(this.guessbox_click);
            this.guessbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessbox_keydown);
            // 
            // lblcurrentlevel
            // 
            this.lblcurrentlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrentlevel.Location = new System.Drawing.Point(-6, 77);
            this.lblcurrentlevel.Name = "lblcurrentlevel";
            this.lblcurrentlevel.Size = new System.Drawing.Size(331, 42);
            this.lblcurrentlevel.TabIndex = 8;
            this.lblcurrentlevel.Text = "Current Level: 1";
            this.lblcurrentlevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(340, 12);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(123, 18);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "All Ready Done";
            // 
            // listblistedstuff
            // 
            this.listblistedstuff.BackColor = System.Drawing.Color.Black;
            this.listblistedstuff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listblistedstuff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listblistedstuff.ForeColor = System.Drawing.Color.White;
            this.listblistedstuff.FormattingEnabled = true;
            this.listblistedstuff.Location = new System.Drawing.Point(340, 41);
            this.listblistedstuff.Name = "listblistedstuff";
            this.listblistedstuff.ScrollAlwaysVisible = true;
            this.listblistedstuff.Size = new System.Drawing.Size(129, 221);
            this.listblistedstuff.TabIndex = 6;
            this.listblistedstuff.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listblistedstuff_DrawItem);
            // 
            // lbltillnextlevel
            // 
            this.lbltillnextlevel.AutoSize = true;
            this.lbltillnextlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltillnextlevel.Location = new System.Drawing.Point(8, 250);
            this.lbltillnextlevel.Name = "lbltillnextlevel";
            this.lbltillnextlevel.Size = new System.Drawing.Size(146, 16);
            this.lbltillnextlevel.TabIndex = 5;
            this.lbltillnextlevel.Text = "Words Until Next Level:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(191, 250);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(66, 16);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "Guessed:";
            // 
            // btnstart
            // 
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(11, 198);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(297, 46);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "Submit Word";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lblcatedescription
            // 
            this.lblcatedescription.Location = new System.Drawing.Point(11, 48);
            this.lblcatedescription.Name = "lblcatedescription";
            this.lblcatedescription.Size = new System.Drawing.Size(297, 26);
            this.lblcatedescription.TabIndex = 1;
            this.lblcatedescription.Text = "There are many animals out there! Can you list them all? Note that this is a list" +
    " of common animals, not every animal!";
            this.lblcatedescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcategory
            // 
            this.lblcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.Location = new System.Drawing.Point(11, 8);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(297, 39);
            this.lblcategory.TabIndex = 0;
            this.lblcategory.Text = "Animals";
            this.lblcategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(52, 235);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(382, 20);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Select A Category On the Left To Start Playing";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(187, 72);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(112, 20);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "How To Play:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(61, 97);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(383, 80);
            this.Label2.TabIndex = 1;
            this.Label2.Text = resources.GetString("Label2.Text");
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(75, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(316, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Welcome to Knowledge Input";
            // 
            // decider
            // 
            this.decider.Interval = 500;
            this.decider.Tick += new System.EventHandler(this.decider_Tick);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(30, 8);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(130, 28);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "Categories";
            // 
            // pgcontents
            // 
            this.pgcontents.BackColor = System.Drawing.Color.White;
            this.pgcontents.Controls.Add(this.pnlintro);
            this.pgcontents.Controls.Add(this.Label6);
            this.pgcontents.Controls.Add(this.ListBox1);
            this.pgcontents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgcontents.Location = new System.Drawing.Point(0, 0);
            this.pgcontents.Name = "pgcontents";
            this.pgcontents.Size = new System.Drawing.Size(673, 304);
            this.pgcontents.TabIndex = 10;
            // 
            // tmrstoryline
            // 
            this.tmrstoryline.Interval = 1000;
            // 
            // KnowledgeInput
            // 
            this.AcceptButton = this.btnstart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(673, 304);
            this.Controls.Add(this.pgcontents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "KnowledgeInput";
            this.Text = "Knowledge_Input";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Template_Load);
            this.pnlintro.ResumeLayout(false);
            this.pnlintro.PerformLayout();
            this.pnlcategorydisplay.ResumeLayout(false);
            this.pnlcategorydisplay.PerformLayout();
            this.pgcontents.ResumeLayout(false);
            this.pgcontents.PerformLayout();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Panel pnlintro;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel pnlcategorydisplay;
        internal System.Windows.Forms.Label lblcategory;
        internal System.Windows.Forms.Button btnstart;
        internal System.Windows.Forms.Label lblcatedescription;
        internal System.Windows.Forms.Label lbltillnextlevel;
        internal System.Windows.Forms.Label lbltotal;
        internal System.Windows.Forms.ListBox listblistedstuff;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox guessbox;
        internal System.Windows.Forms.Label lblcurrentlevel;
        internal System.Windows.Forms.Timer decider;
        internal System.Windows.Forms.Label lblnextreward;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Panel pgcontents;
        internal System.Windows.Forms.Timer tmrstoryline;
    }
}