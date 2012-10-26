csharp-ArgbColorDialog

#Winforms Alpha Color Dialog

Color dialog with alpha channel support.
BSD license, for more information see 'license.txt'.

![Screenshot](https://github.com/bvssvni/csharp-ArgbColorDialog/blob/master/screenshot.png)

This dialog contains:

1. Standard Windows 8x6 colors.
2. HSV tuning (hue, saturation, brightness).
3. RGB hexadecimal colors.
4. Alpha channel.

##Usage

Import namespaces:

    import System.Windows.Forms;
    import System.Drawing;
    import CutoutPro.Winforms;
    
In a function, create a new instance of the dialog and set the Color property.
    
    ArgbColorDialog dialog = new ArgbColorDialog();
    dialog.Color = Color.SkyBlue;
    dialog.ShowDialog();
    
Alternative, you can use the control directly as integrated part of your interface:

    ArgbColorControl control = new ArgbColorControl();
    control.Color = Color.SkyBlue;
    this.Controls.Add(control);

See 'TestArgbColorDialog' for example project.