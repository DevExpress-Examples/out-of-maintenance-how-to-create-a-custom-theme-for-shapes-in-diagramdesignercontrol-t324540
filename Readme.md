<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585181/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T324540)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[CustomShapeTheme.xaml](./CS/CustomShapeThemes/CustomShapeTheme.xaml) (VB: [CustomShapeTheme.xaml](./VB/CustomShapeThemes/CustomShapeTheme.xaml))**
* [MainWindow.xaml](./CS/CustomShapeThemes/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomShapeThemes/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomShapeThemes/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomShapeThemes/MainWindow.xaml.vb))
<!-- default file list end -->
# How to create a custom theme for shapes in DiagramDesignerControl


<p>Shapes in the Diagram control are colored according to the applied theme. To create a custom theme, add a resource dictionary with a Theme element to your application. <br>Each theme should contain a color palette. To specify a color palette, add the <em>ColorPalette</em> element into the Theme. <br><br>To specify how colors are used in a theme, set the <em>Theme.Effects</em> property. This property accepts the <em>EffectCollection</em> object. EffectCollection defines colors shown in the following gallery:</p>
<img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-custom-theme-for-shapes-in-diagramdesignercontrol-t324540/15.2.4+/media/fa41b68c-aa14-11e5-80bf-00155d62480c.png"><br>
<p>EffectCollection has the following properties

* <em>ThemeEffects</em>. Specifies colors in the "Theme Styles" group.  This collection contains exactly 6 elements.
* <em>VariantEffects</em>. Specifies colors in the "Variant Styles" group. When a shape is created its default color scheme is taken from this group. This collection contains exactly 4 elements.
* <em>ConnectorEffects</em>. Specifies connector colors. This collection contains exactly 3 elements.<br> <br>To register a custom theme, use the <em>ThemeRegistrator.RegisterThemes</em> method. </p>

<br/>


