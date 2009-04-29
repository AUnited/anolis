namespace Anolis.Resourcer {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ToolStripSeparator @__tSep1;
			System.Windows.Forms.ToolStripSeparator @__tSep2;
			System.Windows.Forms.ToolStripSeparator @__tSrcMruSep;
			System.Windows.Forms.ToolStripSeparator @__tSrcSaveSep;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.@__sSep1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.@__sSep2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.@__resCMSep = new System.Windows.Forms.ToolStripSeparator();
			this.@__tree = new System.Windows.Forms.TreeView();
			this.@__stateImages = new System.Windows.Forms.ImageList(this.components);
			this.@__split = new System.Windows.Forms.SplitContainer();
			this.@__nav = new System.Windows.Forms.ToolStrip();
			this.@__navBack = new System.Windows.Forms.ToolStripButton();
			this.@__navUp = new System.Windows.Forms.ToolStripButton();
			this.@__ofd = new System.Windows.Forms.OpenFileDialog();
			this.@__sfd = new System.Windows.Forms.SaveFileDialog();
			this.@__status = new System.Windows.Forms.StatusStrip();
			this.@__sPath = new System.Windows.Forms.ToolStripStatusLabel();
			this.@__sType = new System.Windows.Forms.ToolStripStatusLabel();
			this.@__sSize = new System.Windows.Forms.ToolStripStatusLabel();
			this.@__t = new System.Windows.Forms.ToolStrip();
			this.@__tSrcOpen = new System.Windows.Forms.ToolStripSplitButton();
			this.@__tSrcMruInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.@__tSrcMruClear = new System.Windows.Forms.ToolStripMenuItem();
			this.@__tSrcSave = new System.Windows.Forms.ToolStripSplitButton();
			this.@__tSrcSaveBackup = new System.Windows.Forms.ToolStripMenuItem();
			this.@__tSrcSavePending = new System.Windows.Forms.ToolStripMenuItem();
			this.@__tSrcReve = new System.Windows.Forms.ToolStripButton();
			this.@__tResAdd = new System.Windows.Forms.ToolStripButton();
			this.@__tResExt = new System.Windows.Forms.ToolStripButton();
			this.@__tResRep = new System.Windows.Forms.ToolStripButton();
			this.@__tResDel = new System.Windows.Forms.ToolStripButton();
			this.@__tResCan = new System.Windows.Forms.ToolStripButton();
			this.@__tGenOpt = new System.Windows.Forms.ToolStripButton();
			this.@__treeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.@__resCMCast = new System.Windows.Forms.ToolStripMenuItem();
			this.@__resCMExtract = new System.Windows.Forms.ToolStripMenuItem();
			this.@__resCMReplace = new System.Windows.Forms.ToolStripMenuItem();
			this.@__resCMDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.@__resCMCancel = new System.Windows.Forms.ToolStripMenuItem();
			this.@__dropTarget = new Anolis.Resourcer.Controls.DropTarget();
			@__tSep1 = new System.Windows.Forms.ToolStripSeparator();
			@__tSep2 = new System.Windows.Forms.ToolStripSeparator();
			@__tSrcMruSep = new System.Windows.Forms.ToolStripSeparator();
			@__tSrcSaveSep = new System.Windows.Forms.ToolStripSeparator();
			this.@__split.Panel1.SuspendLayout();
			this.@__split.SuspendLayout();
			this.@__nav.SuspendLayout();
			this.@__status.SuspendLayout();
			this.@__t.SuspendLayout();
			this.@__treeMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// __tSep1
			// 
			@__tSep1.Name = "__tSep1";
			@__tSep1.Size = new System.Drawing.Size(6, 71);
			// 
			// __tSep2
			// 
			@__tSep2.Name = "__tSep2";
			@__tSep2.Padding = new System.Windows.Forms.Padding(3);
			@__tSep2.Size = new System.Drawing.Size(6, 71);
			// 
			// __tSrcMruSep
			// 
			@__tSrcMruSep.Name = "__tSrcMruSep";
			@__tSrcMruSep.Size = new System.Drawing.Size(148, 6);
			// 
			// __tSrcSaveSep
			// 
			@__tSrcSaveSep.Name = "__tSrcSaveSep";
			@__tSrcSaveSep.Size = new System.Drawing.Size(177, 6);
			// 
			// __sSep1
			// 
			this.@__sSep1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.@__sSep1.Name = "__sSep1";
			this.@__sSep1.Size = new System.Drawing.Size(4, 17);
			// 
			// __sSep2
			// 
			this.@__sSep2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.@__sSep2.Name = "__sSep2";
			this.@__sSep2.Size = new System.Drawing.Size(4, 17);
			// 
			// __resCMSep
			// 
			this.@__resCMSep.Name = "__resCMSep";
			this.@__resCMSep.Size = new System.Drawing.Size(130, 6);
			// 
			// __tree
			// 
			this.@__tree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.@__tree.Location = new System.Drawing.Point(0, 25);
			this.@__tree.Name = "__tree";
			this.@__tree.ShowRootLines = false;
			this.@__tree.Size = new System.Drawing.Size(150, 353);
			this.@__tree.StateImageList = this.@__stateImages;
			this.@__tree.TabIndex = 3;
			// 
			// __stateImages
			// 
			this.@__stateImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("__stateImages.ImageStream")));
			this.@__stateImages.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.@__stateImages.Images.SetKeyName(0, "Add");
			this.@__stateImages.Images.SetKeyName(1, "Delete");
			this.@__stateImages.Images.SetKeyName(2, "Edit");
			// 
			// __split
			// 
			this.@__split.Dock = System.Windows.Forms.DockStyle.Fill;
			this.@__split.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.@__split.Location = new System.Drawing.Point(0, 74);
			this.@__split.Margin = new System.Windows.Forms.Padding(0);
			this.@__split.Name = "__split";
			// 
			// __split.Panel1
			// 
			this.@__split.Panel1.Controls.Add(this.@__tree);
			this.@__split.Panel1.Controls.Add(this.@__nav);
			this.@__split.Size = new System.Drawing.Size(635, 378);
			this.@__split.SplitterDistance = 150;
			this.@__split.TabIndex = 4;
			// 
			// __nav
			// 
			this.@__nav.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.@__nav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__navBack,
            this.@__navUp});
			this.@__nav.Location = new System.Drawing.Point(0, 0);
			this.@__nav.Name = "__nav";
			this.@__nav.Size = new System.Drawing.Size(150, 25);
			this.@__nav.TabIndex = 4;
			// 
			// __navBack
			// 
			this.@__navBack.Enabled = false;
			this.@__navBack.Image = global::Anolis.Resourcer.Resources.NavBackUp;
			this.@__navBack.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.@__navBack.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.@__navBack.Name = "__navBack";
			this.@__navBack.Size = new System.Drawing.Size(49, 22);
			this.@__navBack.Text = "Back";
			// 
			// __navUp
			// 
			this.@__navUp.Enabled = false;
			this.@__navUp.Image = global::Anolis.Resourcer.Resources.NavUpUp;
			this.@__navUp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.@__navUp.Name = "__navUp";
			this.@__navUp.Size = new System.Drawing.Size(40, 22);
			this.@__navUp.Text = "Up";
			// 
			// __status
			// 
			this.@__status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__sPath,
            this.@__sSep1,
            this.@__sType,
            this.@__sSep2,
            this.@__sSize});
			this.@__status.Location = new System.Drawing.Point(0, 452);
			this.@__status.Name = "__status";
			this.@__status.Size = new System.Drawing.Size(635, 22);
			this.@__status.TabIndex = 5;
			this.@__status.Text = "statusStrip1";
			// 
			// __sPath
			// 
			this.@__sPath.Name = "__sPath";
			this.@__sPath.Size = new System.Drawing.Size(124, 17);
			this.@__sPath.Text = "                                       ";
			// 
			// __sType
			// 
			this.@__sType.Name = "__sType";
			this.@__sType.Size = new System.Drawing.Size(121, 17);
			this.@__sType.Text = "                                      ";
			// 
			// __sSize
			// 
			this.@__sSize.Name = "__sSize";
			this.@__sSize.Size = new System.Drawing.Size(61, 17);
			this.@__sSize.Text = "                  ";
			// 
			// __t
			// 
			this.@__t.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.@__t.ImageScalingSize = new System.Drawing.Size(48, 48);
			this.@__t.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__tSrcOpen,
            this.@__tSrcSave,
            this.@__tSrcReve,
            @__tSep1,
            this.@__tResAdd,
            this.@__tResExt,
            this.@__tResRep,
            this.@__tResDel,
            this.@__tResCan,
            @__tSep2,
            this.@__tGenOpt});
			this.@__t.Location = new System.Drawing.Point(0, 0);
			this.@__t.Name = "__t";
			this.@__t.Padding = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.@__t.Size = new System.Drawing.Size(635, 74);
			this.@__t.Stretch = true;
			this.@__t.TabIndex = 6;
			// 
			// __tSrcOpen
			// 
			this.@__tSrcOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__tSrcMruInfo,
            @__tSrcMruSep,
            this.@__tSrcMruClear});
			this.@__tSrcOpen.Image = global::Anolis.Resourcer.Resources.Toolbar_SrcOpen;
			this.@__tSrcOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.@__tSrcOpen.Margin = new System.Windows.Forms.Padding(0);
			this.@__tSrcOpen.Name = "__tSrcOpen";
			this.@__tSrcOpen.Padding = new System.Windows.Forms.Padding(3);
			this.@__tSrcOpen.Size = new System.Drawing.Size(70, 71);
			this.@__tSrcOpen.Text = "Open";
			this.@__tSrcOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.@__tSrcOpen.ToolTipText = "Open a file containing resources";
			// 
			// __tSrcMruInfo
			// 
			this.@__tSrcMruInfo.Enabled = false;
			this.@__tSrcMruInfo.Name = "__tSrcMruInfo";
			this.@__tSrcMruInfo.Size = new System.Drawing.Size(151, 22);
			this.@__tSrcMruInfo.Text = "Recent Files List";
			// 
			// __tSrcMruClear
			// 
			this.@__tSrcMruClear.Name = "__tSrcMruClear";
			this.@__tSrcMruClear.Size = new System.Drawing.Size(151, 22);
			this.@__tSrcMruClear.Text = "Clear List";
			// 
			// __tSrcSave
			// 
			this.@__tSrcSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__tSrcSaveBackup,
            @__tSrcSaveSep,
            this.@__tSrcSavePending});
			this.@__tSrcSave.Image = global::Anolis.Resourcer.Resources.Toolbar_SrcSave;
			this.@__tSrcSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.@__tSrcSave.Margin = new System.Windows.Forms.Padding(0);
			this.@__tSrcSave.Name = "__tSrcSave";
			this.@__tSrcSave.Padding = new System.Windows.Forms.Padding(3);
			this.@__tSrcSave.Size = new System.Drawing.Size(70, 71);
			this.@__tSrcSave.Text = "Save";
			this.@__tSrcSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// __tSrcSaveBackup
			// 
			this.@__tSrcSaveBackup.Name = "__tSrcSaveBackup";
			this.@__tSrcSaveBackup.Size = new System.Drawing.Size(180, 22);
			this.@__tSrcSaveBackup.Text = "Backup Source...";
			// 
			// __tSrcSavePending
			// 
			this.@__tSrcSavePending.Name = "__tSrcSavePending";
			this.@__tSrcSavePending.Size = new System.Drawing.Size(180, 22);
			this.@__tSrcSavePending.Text = "Pending Operations...";
			// 
			// __tSrcReve
			// 
			this.@__tSrcReve.Image = global::Anolis.Resourcer.Resources.Toolbar_SrcRev;
			this.@__tSrcReve.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.@__tSrcReve.Margin = new System.Windows.Forms.Padding(0);
			this.@__tSrcReve.Name = "__tSrcReve";
			this.@__tSrcReve.Padding = new System.Windows.Forms.Padding(3);
			this.@__tSrcReve.Size = new System.Drawing.Size(58, 71);
			this.@__tSrcReve.Text = "Revert";
			this.@__tSrcReve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.@__tSrcReve.ToolTipText = "Revert the resource containing file to its last-saved state";
			// 
			// __tResAdd
			// 
			this.@__tResAdd.Image = global::Anolis.Resourcer.Resources.Toolbar_ResAdd;
			this.@__tResAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.@__tResAdd.Margin = new System.Windows.Forms.Padding(0);
			this.@__tResAdd.Name = "__tResAdd";
			this.@__tResAdd.Padding = new System.Windows.Forms.Padding(3);
			this.@__tResAdd.Size = new System.Drawing.Size(58, 71);
			this.@__tResAdd.Text = "Import";
			this.@__tResAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.@__tResAdd.ToolTipText = "Add a new resource";
			// 
			// __tResExt
			// 
			this.@__tResExt.Image = global::Anolis.Resourcer.Resources.Toolbar_ResExt;
			this.@__tResExt.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.@__tResExt.Margin = new System.Windows.Forms.Padding(0);
			this.@__tResExt.Name = "__tResExt";
			this.@__tResExt.Padding = new System.Windows.Forms.Padding(3);
			this.@__tResExt.Size = new System.Drawing.Size(58, 71);
			this.@__tResExt.Text = "Export";
			this.@__tResExt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.@__tResExt.ToolTipText = "Extract the currently selected resource to disk";
			// 
			// __tResRep
			// 
			this.@__tResRep.Image = global::Anolis.Resourcer.Resources.Toolbar_ResRep;
			this.@__tResRep.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.@__tResRep.Margin = new System.Windows.Forms.Padding(0);
			this.@__tResRep.Name = "__tResRep";
			this.@__tResRep.Padding = new System.Windows.Forms.Padding(3);
			this.@__tResRep.Size = new System.Drawing.Size(58, 71);
			this.@__tResRep.Text = "Replace";
			this.@__tResRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.@__tResRep.ToolTipText = "Replace the currently selected resource wth a new file from disk";
			// 
			// __tResDel
			// 
			this.@__tResDel.Image = global::Anolis.Resourcer.Resources.Toolbar_ResDel;
			this.@__tResDel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.@__tResDel.Margin = new System.Windows.Forms.Padding(0);
			this.@__tResDel.Name = "__tResDel";
			this.@__tResDel.Padding = new System.Windows.Forms.Padding(3);
			this.@__tResDel.Size = new System.Drawing.Size(58, 71);
			this.@__tResDel.Text = "Delete";
			this.@__tResDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.@__tResDel.ToolTipText = "Marks the currently selected resource for deletion when saved";
			// 
			// __tResCan
			// 
			this.@__tResCan.Image = global::Anolis.Resourcer.Resources.Toolbar_ResCan;
			this.@__tResCan.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.@__tResCan.Margin = new System.Windows.Forms.Padding(0);
			this.@__tResCan.Name = "__tResCan";
			this.@__tResCan.Padding = new System.Windows.Forms.Padding(3);
			this.@__tResCan.Size = new System.Drawing.Size(58, 71);
			this.@__tResCan.Text = "Cancel";
			this.@__tResCan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.@__tResCan.ToolTipText = "Cancel the pending operation on the current resource";
			// 
			// __tGenOpt
			// 
			this.@__tGenOpt.Image = global::Anolis.Resourcer.Resources.Toolbar_GenOpt;
			this.@__tGenOpt.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.@__tGenOpt.Margin = new System.Windows.Forms.Padding(0);
			this.@__tGenOpt.Name = "__tGenOpt";
			this.@__tGenOpt.Padding = new System.Windows.Forms.Padding(3);
			this.@__tGenOpt.Size = new System.Drawing.Size(58, 71);
			this.@__tGenOpt.Text = "Options";
			this.@__tGenOpt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.@__tGenOpt.ToolTipText = "Options, Credits, and License";
			// 
			// __treeMenu
			// 
			this.@__treeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__resCMCast,
            this.@__resCMSep,
            this.@__resCMExtract,
            this.@__resCMReplace,
            this.@__resCMDelete,
            this.@__resCMCancel});
			this.@__treeMenu.Name = "__resCM";
			this.@__treeMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.@__treeMenu.Size = new System.Drawing.Size(134, 120);
			// 
			// __resCMCast
			// 
			this.@__resCMCast.Name = "__resCMCast";
			this.@__resCMCast.Size = new System.Drawing.Size(133, 22);
			this.@__resCMCast.Text = "Cast {0} as:";
			// 
			// __resCMExtract
			// 
			this.@__resCMExtract.Name = "__resCMExtract";
			this.@__resCMExtract.Size = new System.Drawing.Size(133, 22);
			this.@__resCMExtract.Text = "Extract {0}";
			// 
			// __resCMReplace
			// 
			this.@__resCMReplace.Name = "__resCMReplace";
			this.@__resCMReplace.Size = new System.Drawing.Size(133, 22);
			this.@__resCMReplace.Text = "Replace {0}";
			// 
			// __resCMDelete
			// 
			this.@__resCMDelete.Name = "__resCMDelete";
			this.@__resCMDelete.Size = new System.Drawing.Size(133, 22);
			this.@__resCMDelete.Text = "Delete {0}";
			// 
			// __resCMCancel
			// 
			this.@__resCMCancel.Name = "__resCMCancel";
			this.@__resCMCancel.Size = new System.Drawing.Size(133, 22);
			this.@__resCMCancel.Text = "Cancel {0}";
			// 
			// __dropTarget
			// 
			this.@__dropTarget.AllowDrop = true;
			this.@__dropTarget.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.@__dropTarget.DropDataAddEnabled = true;
			this.@__dropTarget.DropDataReplaceEnabled = true;
			this.@__dropTarget.Location = new System.Drawing.Point(200, 100);
			this.@__dropTarget.Name = "__dropTarget";
			this.@__dropTarget.Size = new System.Drawing.Size(376, 93);
			this.@__dropTarget.TabIndex = 0;
			this.@__dropTarget.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(635, 474);
			this.Controls.Add(this.@__dropTarget);
			this.Controls.Add(this.@__split);
			this.Controls.Add(this.@__t);
			this.Controls.Add(this.@__status);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Anolis Resourcer";
			this.@__split.Panel1.ResumeLayout(false);
			this.@__split.Panel1.PerformLayout();
			this.@__split.ResumeLayout(false);
			this.@__nav.ResumeLayout(false);
			this.@__nav.PerformLayout();
			this.@__status.ResumeLayout(false);
			this.@__status.PerformLayout();
			this.@__t.ResumeLayout(false);
			this.@__t.PerformLayout();
			this.@__treeMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView __tree;
		private System.Windows.Forms.SplitContainer __split;
		private System.Windows.Forms.OpenFileDialog __ofd;
		private System.Windows.Forms.SaveFileDialog __sfd;
		private System.Windows.Forms.StatusStrip __status;
		private System.Windows.Forms.ToolStrip __t;
		private System.Windows.Forms.ToolStripButton __tResExt;
		private System.Windows.Forms.ToolStripButton __tSrcReve;
		private System.Windows.Forms.ToolStripButton __tResAdd;
		private System.Windows.Forms.ToolStripButton __tResRep;
		private System.Windows.Forms.ToolStripButton __tResDel;
		private System.Windows.Forms.ToolStripButton __tGenOpt;
		private System.Windows.Forms.ToolStripStatusLabel __sPath;
		private System.Windows.Forms.ToolStripStatusLabel __sType;
		private System.Windows.Forms.ToolStripStatusLabel __sSize;
		private System.Windows.Forms.ToolStripSplitButton __tSrcOpen;
		private System.Windows.Forms.ContextMenuStrip __treeMenu;
		private System.Windows.Forms.ToolStripMenuItem __resCMExtract;
		private System.Windows.Forms.ToolStripMenuItem __resCMCast;
		private System.Windows.Forms.ToolStripMenuItem __resCMReplace;
		private System.Windows.Forms.ToolStripMenuItem __resCMDelete;
		private System.Windows.Forms.ToolStripStatusLabel __sSep1;
		private System.Windows.Forms.ToolStripStatusLabel __sSep2;
		private System.Windows.Forms.ToolStripSeparator __resCMSep;
		private System.Windows.Forms.ToolStripButton __tResCan;
		private System.Windows.Forms.ToolStripMenuItem __resCMCancel;
		private System.Windows.Forms.ImageList __stateImages;
		private System.Windows.Forms.ToolStripSplitButton __tSrcSave;
		private System.Windows.Forms.ToolStripMenuItem __tSrcSaveBackup;
		private System.Windows.Forms.ToolStripMenuItem __tSrcMruInfo;
		private System.Windows.Forms.ToolStripMenuItem __tSrcMruClear;
		private System.Windows.Forms.ToolStripMenuItem __tSrcSavePending;
		private System.Windows.Forms.ToolStrip __nav;
		private System.Windows.Forms.ToolStripButton __navBack;
		private System.Windows.Forms.ToolStripButton __navUp;
		private Anolis.Resourcer.Controls.DropTarget __dropTarget;
	}
}

