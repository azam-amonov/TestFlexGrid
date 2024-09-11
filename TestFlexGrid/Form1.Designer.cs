using C1.Win.C1FlexGrid;

namespace TestFlexGrid
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            C1.Win.C1FlexGrid.FooterDescription footerDescription1 = new C1.Win.C1FlexGrid.FooterDescription();
            C1.Win.C1FlexGrid.AggregateDefinition aggregateDefinition1 = new C1.Win.C1FlexGrid.AggregateDefinition();
            C1.Win.C1FlexGrid.AggregateDefinition aggregateDefinition2 = new C1.Win.C1FlexGrid.AggregateDefinition();
            C1.Win.C1FlexGrid.AggregateDefinition aggregateDefinition3 = new C1.Win.C1FlexGrid.AggregateDefinition();
            C1.Win.C1FlexGrid.AggregateDefinition aggregateDefinition4 = new C1.Win.C1FlexGrid.AggregateDefinition();
            C1.Win.C1FlexGrid.Band band1 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band2 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band3 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band4 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band5 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band6 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band7 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band8 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band9 = new C1.Win.C1FlexGrid.Band();
            this.grid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1FlexGridBandedView1 = new C1.Win.C1FlexGrid.C1FlexGridBandedView();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AutoGenerateColumns = false;
            this.grid.ColumnInfo = resources.GetString("grid.ColumnInfo");
            this.grid.DataSource = this.companyBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            aggregateDefinition1.Aggregate = C1.Win.C1FlexGrid.AggregateEnum.Count;
            aggregateDefinition1.Caption = "Qty: ";
            aggregateDefinition1.Column = 1;
            aggregateDefinition2.Aggregate = C1.Win.C1FlexGrid.AggregateEnum.Sum;
            aggregateDefinition2.Caption = "Sum: ";
            aggregateDefinition2.Column = 5;
            aggregateDefinition3.Aggregate = C1.Win.C1FlexGrid.AggregateEnum.Sum;
            aggregateDefinition3.Column = 4;
            aggregateDefinition4.Aggregate = C1.Win.C1FlexGrid.AggregateEnum.Sum;
            aggregateDefinition4.Column = 6;
            footerDescription1.Aggregates.Add(aggregateDefinition1);
            footerDescription1.Aggregates.Add(aggregateDefinition2);
            footerDescription1.Aggregates.Add(aggregateDefinition3);
            footerDescription1.Aggregates.Add(aggregateDefinition4);
            this.grid.Footers.Descriptions.Add(footerDescription1);
            this.grid.Footers.Fixed = true;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.Rows.Count = 3;
            this.grid.Rows.Fixed = 2;
            this.grid.Size = new System.Drawing.Size(800, 450);
            this.grid.StyleInfo = resources.GetString("grid.StyleInfo");
            this.grid.TabIndex = 0;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(TestFlexGrid.Company);
            // 
            // c1FlexGridBandedView1
            // 
            band1.Caption = "Identificator";
            band1.Name = "BandId";
            band2.Caption = "Company";
            band3.Caption = "Name";
            band3.Name = "BandName";
            band4.Caption = "TaxNo";
            band4.Name = "BandTaxNo";
            band2.Children.Add(band3);
            band2.Children.Add(band4);
            band2.Name = "BandCompany";
            band5.Caption = "Purchases";
            band6.Caption = "Sum";
            band6.Name = "BandSum";
            band7.Caption = "SumVat";
            band7.Name = "BandSumVat";
            band8.Caption = "Amount";
            band8.Name = "BandAmount";
            band5.Children.Add(band6);
            band5.Children.Add(band7);
            band5.Children.Add(band8);
            band5.Name = "BandPurchases";
            band9.Caption = "Description";
            band9.Name = "BandDesc";
            this.c1FlexGridBandedView1.Bands.Add(band1);
            this.c1FlexGridBandedView1.Bands.Add(band2);
            this.c1FlexGridBandedView1.Bands.Add(band5);
            this.c1FlexGridBandedView1.Bands.Add(band9);
            this.c1FlexGridBandedView1.FlexGrid = this.grid;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1FlexGrid grid;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private C1FlexGridBandedView c1FlexGridBandedView1;
    }
}

