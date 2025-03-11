﻿using System.ComponentModel;

namespace DatabaseViewForm;

partial class NavigationView
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        UserButton = new System.Windows.Forms.Button();
        LanguageButton = new System.Windows.Forms.Button();
        RegistrationButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // UserButton
        // 
        UserButton.Location = new System.Drawing.Point(121, 151);
        UserButton.Name = "UserButton";
        UserButton.Size = new System.Drawing.Size(124, 25);
        UserButton.TabIndex = 0;
        UserButton.Text = "User";
        UserButton.UseVisualStyleBackColor = true;
        UserButton.Click += button1_Click_1;
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new System.Drawing.Point(339, 151);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new System.Drawing.Size(124, 25);
        LanguageButton.TabIndex = 1;
        LanguageButton.Text = "Language";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += button2_Click;
        // 
        // RegistrationButton
        // 
        RegistrationButton.Location = new System.Drawing.Point(537, 151);
        RegistrationButton.Name = "RegistrationButton";
        RegistrationButton.Size = new System.Drawing.Size(124, 25);
        RegistrationButton.TabIndex = 2;
        RegistrationButton.Text = "Registrations";
        RegistrationButton.UseVisualStyleBackColor = true;
        // 
        // NavigationView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(RegistrationButton);
        Controls.Add(LanguageButton);
        Controls.Add(UserButton);
        Size = new System.Drawing.Size(800, 450);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button LanguageButton;
    private System.Windows.Forms.Button RegistrationButton;

    private System.Windows.Forms.Button UserButton;

    #endregion
}