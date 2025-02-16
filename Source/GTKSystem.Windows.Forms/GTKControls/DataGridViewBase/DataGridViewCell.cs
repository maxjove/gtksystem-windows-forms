﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace System.Windows.Forms
{
    public abstract class DataGridViewCell
    {
        internal DataGridViewRow OwningRowInternal { get; set; }
        public DataGridView DataGridView { get; set; }
        protected DataGridViewCell() { }
        public object Value { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ToolTipText { get; set; }
        [Bindable(true)]
        [DefaultValue(null)]
        [Localizable(false)]
        [TypeConverter(typeof(StringConverter))]
        public object Tag { get; set; }
        [Browsable(true)]
        public DataGridViewCellStyle Style { get; set; }

        public Size Size { get; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual bool Selected { get; set; }

        public int RowIndex { get; }

        public virtual bool Resizable { get; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual bool ReadOnly { get; set; }

        public Size PreferredSize { get; }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public DataGridViewRow OwningRow { get; }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public DataGridViewColumn OwningColumn { get; }

        public bool IsInEditMode { get; }

        public DataGridViewCellStyle InheritedStyle { get; }

        public AccessibleObject AccessibilityObject { get; }
        public int ColumnIndex { get; }

        public Rectangle ContentBounds { get; }
        [DefaultValue(null)]
        public virtual ContextMenuStrip ContextMenuStrip { get; set; }

        public virtual object DefaultNewRowValue { get; }

        public virtual bool Displayed { get; }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public object EditedFormattedValue { get; }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public virtual Type EditType { get; }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Rectangle ErrorIconBounds { get; }

        public string ErrorText { get; set; }

        public object FormattedValue { get; }

        public virtual Type FormattedValueType { get; }

        public virtual bool Frozen { get; }

        public virtual bool Visible { get; }

        public bool HasStyle { get; }

        public DataGridViewElementStates InheritedState { get; }

        public virtual Type ValueType { get; set; }
    }
    public class DataGridViewTextBoxCell : DataGridViewCell
    {
        //public DataGridViewTextBoxCell(DataGridViewRow dataGridViewRow) {
         
        //}
    }
    public class DataGridViewCheckBoxCell : DataGridViewCell
    {
    }
    public class DataGridViewRadioCell : DataGridViewCell
    {
    }
    public class DataGridViewComboBoxCell : DataGridViewCell
    {
    }
    public class DataGridViewButtonCell : DataGridViewCell
    {
    }
    public class DataGridViewImageCell : DataGridViewCell
    {
    }
    public class DataGridViewLinkCell : DataGridViewCell
    {
    }
}
