﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31EB650DC79A6A35898EE2BA0ECF68A76E60C9FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ConwaysGameOfLife;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ConwaysGameOfLife {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas fieldView;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ConwaysGameOfLife.VisualHost fieldVisuals;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel drawingPanel;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button liveCellColorButton;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox drawDeadCellBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deadCellColorButton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox drawBackgroundBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backgroundColorButton;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ColorVisual;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider ColorRSlider;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider ColorGSlider;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider ColorBSlider;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel settingsPanel;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fieldResolutionLabel;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider fieldResolutionSlider;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label randomSizeLabel;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider randomSizeSlider;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label autoPlaySpeedLabel;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider autoPlaySpeedSlider;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button underpopUpButton;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button underpopDownButton;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label underpopulationLabel;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button overpopulationUpButton;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button overpopulationDownButton;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label overpopulationLabel;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label birthPopulationLabel;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox birthPopulation1Checkbox;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox birthPopulation2Checkbox;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox birthPopulation3Checkbox;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox birthPopulation4Checkbox;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox birthPopulation5Checkbox;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox birthPopulation6Checkbox;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox birthPopulation7Checkbox;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox birthPopulation8Checkbox;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fieldMoveUpButton;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fieldMoveDownButton;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fieldMoveLeftButton;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fieldMoveRightButton;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label infoLabelLeft;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label infoLabelRight;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextGenButton;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PatternBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ConwaysGameOfLife;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\MainWindow.xaml"
            ((ConwaysGameOfLife.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MainWindow_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\MainWindow.xaml"
            ((ConwaysGameOfLife.MainWindow)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.MainWindow_SizeChanged);
            
            #line default
            #line hidden
            
            #line 9 "..\..\MainWindow.xaml"
            ((ConwaysGameOfLife.MainWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MainWindow_MouseDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\MainWindow.xaml"
            ((ConwaysGameOfLife.MainWindow)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.MainWindow_MouseMoved);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fieldView = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.fieldVisuals = ((ConwaysGameOfLife.VisualHost)(target));
            return;
            case 4:
            this.drawingPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.liveCellColorButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\MainWindow.xaml"
            this.liveCellColorButton.Click += new System.Windows.RoutedEventHandler(this.ColorSelector_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.drawDeadCellBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 55 "..\..\MainWindow.xaml"
            this.drawDeadCellBox.Checked += new System.Windows.RoutedEventHandler(this.DrawFieldItems_Checked);
            
            #line default
            #line hidden
            
            #line 55 "..\..\MainWindow.xaml"
            this.drawDeadCellBox.Unchecked += new System.Windows.RoutedEventHandler(this.DrawFieldItems_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.deadCellColorButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\MainWindow.xaml"
            this.deadCellColorButton.Click += new System.Windows.RoutedEventHandler(this.ColorSelector_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.drawBackgroundBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.drawBackgroundBox.Checked += new System.Windows.RoutedEventHandler(this.DrawBackground_Checked);
            
            #line default
            #line hidden
            
            #line 59 "..\..\MainWindow.xaml"
            this.drawBackgroundBox.Unchecked += new System.Windows.RoutedEventHandler(this.DrawBackground_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.backgroundColorButton = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\MainWindow.xaml"
            this.backgroundColorButton.Click += new System.Windows.RoutedEventHandler(this.ColorSelector_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ColorVisual = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 11:
            this.ColorRSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 73 "..\..\MainWindow.xaml"
            this.ColorRSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorRGBSlider_Changed);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ColorGSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 77 "..\..\MainWindow.xaml"
            this.ColorGSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorRGBSlider_Changed);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ColorBSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 81 "..\..\MainWindow.xaml"
            this.ColorBSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorRGBSlider_Changed);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 84 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SetColor_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.settingsPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 16:
            this.fieldResolutionLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 17:
            this.fieldResolutionSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 95 "..\..\MainWindow.xaml"
            this.fieldResolutionSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.FieldResolutionSlider_Changed);
            
            #line default
            #line hidden
            return;
            case 18:
            this.randomSizeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 19:
            this.randomSizeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 100 "..\..\MainWindow.xaml"
            this.randomSizeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.RandomSizeSlider_Changed);
            
            #line default
            #line hidden
            return;
            case 20:
            this.autoPlaySpeedLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 21:
            this.autoPlaySpeedSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 105 "..\..\MainWindow.xaml"
            this.autoPlaySpeedSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.AutoPlaySpeedSlider_Changed);
            
            #line default
            #line hidden
            return;
            case 22:
            this.underpopUpButton = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\MainWindow.xaml"
            this.underpopUpButton.Click += new System.Windows.RoutedEventHandler(this.Underpopulation_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.underpopDownButton = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\MainWindow.xaml"
            this.underpopDownButton.Click += new System.Windows.RoutedEventHandler(this.Underpopulation_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            this.underpopulationLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 25:
            this.overpopulationUpButton = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\MainWindow.xaml"
            this.overpopulationUpButton.Click += new System.Windows.RoutedEventHandler(this.Overpopulation_Click);
            
            #line default
            #line hidden
            return;
            case 26:
            this.overpopulationDownButton = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\MainWindow.xaml"
            this.overpopulationDownButton.Click += new System.Windows.RoutedEventHandler(this.Overpopulation_Click);
            
            #line default
            #line hidden
            return;
            case 27:
            this.overpopulationLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 28:
            this.birthPopulationLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 29:
            this.birthPopulation1Checkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 141 "..\..\MainWindow.xaml"
            this.birthPopulation1Checkbox.Checked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            
            #line 141 "..\..\MainWindow.xaml"
            this.birthPopulation1Checkbox.Unchecked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            return;
            case 30:
            this.birthPopulation2Checkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 143 "..\..\MainWindow.xaml"
            this.birthPopulation2Checkbox.Checked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            
            #line 143 "..\..\MainWindow.xaml"
            this.birthPopulation2Checkbox.Unchecked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            return;
            case 31:
            this.birthPopulation3Checkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 145 "..\..\MainWindow.xaml"
            this.birthPopulation3Checkbox.Checked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            
            #line 145 "..\..\MainWindow.xaml"
            this.birthPopulation3Checkbox.Unchecked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            return;
            case 32:
            this.birthPopulation4Checkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 147 "..\..\MainWindow.xaml"
            this.birthPopulation4Checkbox.Checked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            
            #line 147 "..\..\MainWindow.xaml"
            this.birthPopulation4Checkbox.Unchecked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            return;
            case 33:
            this.birthPopulation5Checkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 149 "..\..\MainWindow.xaml"
            this.birthPopulation5Checkbox.Checked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            
            #line 149 "..\..\MainWindow.xaml"
            this.birthPopulation5Checkbox.Unchecked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            return;
            case 34:
            this.birthPopulation6Checkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 151 "..\..\MainWindow.xaml"
            this.birthPopulation6Checkbox.Checked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            
            #line 151 "..\..\MainWindow.xaml"
            this.birthPopulation6Checkbox.Unchecked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            return;
            case 35:
            this.birthPopulation7Checkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 153 "..\..\MainWindow.xaml"
            this.birthPopulation7Checkbox.Checked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            
            #line 153 "..\..\MainWindow.xaml"
            this.birthPopulation7Checkbox.Unchecked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            return;
            case 36:
            this.birthPopulation8Checkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 155 "..\..\MainWindow.xaml"
            this.birthPopulation8Checkbox.Checked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            
            #line 155 "..\..\MainWindow.xaml"
            this.birthPopulation8Checkbox.Unchecked += new System.Windows.RoutedEventHandler(this.Birthpopulation_Checked);
            
            #line default
            #line hidden
            return;
            case 37:
            this.fieldMoveUpButton = ((System.Windows.Controls.Button)(target));
            
            #line 159 "..\..\MainWindow.xaml"
            this.fieldMoveUpButton.Click += new System.Windows.RoutedEventHandler(this.FieldMoveButton_Click);
            
            #line default
            #line hidden
            return;
            case 38:
            this.fieldMoveDownButton = ((System.Windows.Controls.Button)(target));
            
            #line 164 "..\..\MainWindow.xaml"
            this.fieldMoveDownButton.Click += new System.Windows.RoutedEventHandler(this.FieldMoveButton_Click);
            
            #line default
            #line hidden
            return;
            case 39:
            this.fieldMoveLeftButton = ((System.Windows.Controls.Button)(target));
            
            #line 169 "..\..\MainWindow.xaml"
            this.fieldMoveLeftButton.Click += new System.Windows.RoutedEventHandler(this.FieldMoveButton_Click);
            
            #line default
            #line hidden
            return;
            case 40:
            this.fieldMoveRightButton = ((System.Windows.Controls.Button)(target));
            
            #line 174 "..\..\MainWindow.xaml"
            this.fieldMoveRightButton.Click += new System.Windows.RoutedEventHandler(this.FieldMoveButton_Click);
            
            #line default
            #line hidden
            return;
            case 41:
            this.infoLabelLeft = ((System.Windows.Controls.Label)(target));
            return;
            case 42:
            this.infoLabelRight = ((System.Windows.Controls.Label)(target));
            return;
            case 43:
            
            #line 187 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SettingsButton_Click);
            
            #line default
            #line hidden
            return;
            case 44:
            
            #line 188 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DrawingButton_Click);
            
            #line default
            #line hidden
            return;
            case 45:
            this.nextGenButton = ((System.Windows.Controls.Button)(target));
            
            #line 192 "..\..\MainWindow.xaml"
            this.nextGenButton.Click += new System.Windows.RoutedEventHandler(this.NextGenButton_Click);
            
            #line default
            #line hidden
            return;
            case 46:
            
            #line 193 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AutoPlayButton_Click);
            
            #line default
            #line hidden
            return;
            case 47:
            
            #line 197 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CenterFieldView_Click);
            
            #line default
            #line hidden
            return;
            case 48:
            
            #line 198 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClearFieldView_Click);
            
            #line default
            #line hidden
            return;
            case 49:
            this.PatternBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 50:
            
            #line 200 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadPattern_Click);
            
            #line default
            #line hidden
            return;
            case 51:
            
            #line 201 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RandomField_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

