﻿﻿using System.ComponentModel;

namespace DatabaseViewForm;

partial class LanguageView
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
        UserListView = new System.Windows.Forms.ListView();
        idCol = new System.Windows.Forms.ColumnHeader();
        usernameCol = new System.Windows.Forms.ColumnHeader();
        createdDateCol = new System.Windows.Forms.ColumnHeader();
        modifiedDateCol = new System.Windows.Forms.ColumnHeader();
        FetchButton = new System.Windows.Forms.Button();
        ErrorLabel = new System.Windows.Forms.Label();
        CreateTextBox = new System.Windows.Forms.TextBox();
        CreateButton = new System.Windows.Forms.Button();
        DeleteButton = new System.Windows.Forms.Button();
        DeleteTextBox = new System.Windows.Forms.TextBox();
        BackButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // UserListView
        // 
        UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { idCol, usernameCol, createdDateCol, modifiedDateCol });
        UserListView.Location = new System.Drawing.Point(209, 41);
        UserListView.Name = "UserListView";
        UserListView.Size = new System.Drawing.Size(590, 169);
        UserListView.TabIndex = 0;
        UserListView.UseCompatibleStateImageBehavior = false;
        UserListView.View = System.Windows.Forms.View.Details;
        UserListView.ItemSelectionChanged += UserListView_ItemSelectionChanged;
        // 
        // idCol
        // 
        idCol.Name = "idCol";
        idCol.Text = "Id";
        idCol.Width = 56;
        // 
        // usernameCol
        // 
        usernameCol.Name = "usernameCol";
        usernameCol.Text = "Username";
        usernameCol.Width = 153;
        // 
        // createdDateCol
        // 
        createdDateCol.Name = "createdDateCol";
        createdDateCol.Text = "Created";
        createdDateCol.Width = 94;
        // 
        // modifiedDateCol
        // 
        modifiedDateCol.Name = "modifiedDateCol";
        modifiedDateCol.Text = "Modified";
        modifiedDateCol.Width = 218;
        // 
        // FetchButton
        // 
        FetchButton.Location = new System.Drawing.Point(12, 227);
        FetchButton.Name = "FetchButton";
        FetchButton.Size = new System.Drawing.Size(123, 26);
        FetchButton.TabIndex = 2;
        FetchButton.Text = "Fetch";
        FetchButton.UseVisualStyleBackColor = true;
        FetchButton.Click += FetchButton_Click;
        // 
        // ErrorLabel
        // 
        ErrorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        ErrorLabel.ForeColor = System.Drawing.Color.Red;
        ErrorLabel.Location = new System.Drawing.Point(306, 312);
        ErrorLabel.Name = "ErrorLabel";
        ErrorLabel.Size = new System.Drawing.Size(426, 24);
        ErrorLabel.TabIndex = 3;
        // 
        // CreateTextBox
        // 
        CreateTextBox.Location = new System.Drawing.Point(12, 41);
        CreateTextBox.Name = "CreateTextBox";
        CreateTextBox.Size = new System.Drawing.Size(180, 23);
        CreateTextBox.TabIndex = 4;
        CreateTextBox.KeyDown += TextBoxNewUser_KeyDown;
        // 
        // CreateButton
        // 
        CreateButton.Location = new System.Drawing.Point(12, 70);
        CreateButton.Name = "CreateButton";
        CreateButton.Size = new System.Drawing.Size(88, 25);
        CreateButton.TabIndex = 5;
        CreateButton.Text = "Create Language";
        CreateButton.UseVisualStyleBackColor = true;
        CreateButton.Click += ButtonNewUser_Click;
        // 
        // DeleteButton
        // 
        DeleteButton.Location = new System.Drawing.Point(12, 148);
        DeleteButton.Name = "DeleteButton";
        DeleteButton.Size = new System.Drawing.Size(88, 25);
        DeleteButton.TabIndex = 6;
        DeleteButton.Text = "Delete";
        DeleteButton.UseVisualStyleBackColor = true;
        DeleteButton.Click += ButtonDelete_Click;
        // 
        // DeleteTextBox
        // 
        DeleteTextBox.Location = new System.Drawing.Point(12, 119);
        DeleteTextBox.Name = "DeleteTextBox";
        DeleteTextBox.Size = new System.Drawing.Size(180, 23);
        DeleteTextBox.TabIndex = 7;
        DeleteTextBox.KeyDown += TextBoxDeleteUser_KeyDown;
        // 
        // BackButton
        // 
        BackButton.Location = new System.Drawing.Point(711, 227);
        BackButton.Name = "BackButton";
        BackButton.Size = new System.Drawing.Size(88, 26);
        BackButton.TabIndex = 9;
        BackButton.Text = "Back";
        BackButton.UseVisualStyleBackColor = true;
        BackButton.Click += button2_Click;
        // 
        // LanguageView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(BackButton);
        Controls.Add(DeleteTextBox);
        Controls.Add(DeleteButton);
        Controls.Add(CreateButton);
        Controls.Add(CreateTextBox);
        Controls.Add(ErrorLabel);
        Controls.Add(FetchButton);
        Controls.Add(UserListView);
        Size = new System.Drawing.Size(855, 426);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button BackButton;

    private System.Windows.Forms.TextBox DeleteTextBox;

    private System.Windows.Forms.Button DeleteButton;

    private System.Windows.Forms.TextBox CreateTextBox;
    private System.Windows.Forms.Button CreateButton;

    private System.Windows.Forms.Label ErrorLabel;

    private System.Windows.Forms.Button FetchButton;

    private System.Windows.Forms.ColumnHeader idCol;
    private System.Windows.Forms.ColumnHeader usernameCol;
    private System.Windows.Forms.ColumnHeader createdDateCol;
    private System.Windows.Forms.ColumnHeader modifiedDateCol;

    private System.Windows.Forms.ListView UserListView;

    #endregion
}