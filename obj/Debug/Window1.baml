   M S B A M L   `   `   `  ����  appswindows    appswindows.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStyle$
 None=�6    � WindowStartupLocation$ CenterScreen=�62    � Title$ 
MainWindow��5	   	   $	��600��6   $
��1080��6)    � 	Resources 5
         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background	 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1
 �� 
TargetType �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName  ImageStyle1  ButtonBaseControlTemplate1 J� 	CacheMode �� RelativeSource J� Effect �� Path �� 	Converter9  3MaterialDesignThemes.Wpf.Converters.ShadowConverter �Name # MaterialDesignLinearProgressBar � IsIndeterminate � Maximum � Minimum J� Opacity � Value �� AncestorLevel �� AncestorType%  MaterialDesignThemes.Wpf.Ripple  �� ContentStringFormat! J� Clip" `� UpdateSourceTrigger# �� ElementName+  %MaterialDesignThemes.Wpf.ShadowAssist��%t  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 &	 �    &	 H    �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $	 	#FFDDDDDD��6;   �� 5   
   $	 	#FF707070��67   �� 5   
   $	 	#FFBEE6FD��6>   �� 5   
   $	 	#FF3C7FB1��6:   �� 5   
   $	 	#FFC4E5F6��6<   �� 5   
   $	 	#FF2C628B��68   �� 5   
   $	 	#FFF4F4F4��6=   �� 5   
   $	 	#FFADB2B5��69   �� 5   
   $	 	#FF838383��6=   �� 5   
   "
 ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5        � ��8  6,   �� 5!       � ��# � ��6+   �� 5"       � ��$ 1q�60   �� 5#       � ��$ Center=�6;   �� 5$       � ��$ Center=�69   �� 5%       � ��$ 1q�6(   �� 5&       � �� 5'      �� 5(      " ��6&   .R�5)      �� $ border��6!   $ 20��61   #��z��6C   #��z��6o   #��z��6�    . $��0,0,0,0q�6�   ._�5*      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5+       5,      P� 5-       �@��IsDefaulted . . �5.   "   �� $ border��6@   # � ��6T    � ��5/      P� 50       �@J�IsMouseOver . . �51   "   �� $ border��6?   8   � ��6S   �� 52   "   $ border��6@   8   � ��6T   53      P� 54       � �� . . �55   "   �� $ border��6?   8   � ��6S   �� 56   "   $ border��6@   8   � ��6T   57      P� 58       � {� .  . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   �� 5;   "   $ contentPresenter��6K   8 	  � ��6i   5<      5>      5@      5A      �� 5B   
   "
 ��6$   .�5C      ��  � ��$ LeftToRight=�6.   �� 5D       �@J�OpacityMask 6,   Z� 5E      �� 5F   
   " ��6=   .R�5G      � .+�5H      ��  6#   �� *)'(materialDesign:ShadowAssist.CacheMode)+ �� *Self+.u�5I      � .+�5J      �� $ border��6!   #��z��61   #��z��6]   #��z��6�   $ 30��6�    5K      �� 5L   "   $/ )(materialDesign:ShadowAssist.ShadowDepth)�6*    6[   �� *TemplatedParent+ 5M   &     5N   *   5P   #   5R      � 5S      $ ProgressBar��6&   $
��Left=�6?  #��z��6Z  #���  6X  $��Center=�6  ��6;   �� *;9(materialDesign:ButtonProgressAssist.IndicatorBackground)+ �� *TemplatedParent+��6�   �� *;9(materialDesign:ButtonProgressAssist.IndicatorForeground)+ �� *TemplatedParent+ 6|  �� *75(materialDesign:ButtonProgressAssist.IsIndeterminate)+ �� *TemplatedParent+ 6�  �� */-(materialDesign:ButtonProgressAssist.Maximum)+ �� *TemplatedParent+ 6r  �� */-(materialDesign:ButtonProgressAssist.Minimum)+ �� *TemplatedParent+ 6�  �� */-(materialDesign:ButtonProgressAssist.Opacity)+ �� *TemplatedParent+ 6�  �� *-+(materialDesign:ButtonProgressAssist.Value)+ �� *TemplatedParent+��6  �� *ActualWidth+ �� *FindAncestor+$ 1��" ��y�5T      �� 5U   "   $> 8(materialDesign:ButtonProgressAssist.IsIndicatorVisible)�6*    6j   �� *TemplatedParent+ 5V   &   �� 5W   *   5Y   #   5[      5\      5]        5^      #��z��6(   #��z��6\   #  z  6�   |�.  #��z��6�   #��z��6  # z 6<  #��z��6x  ! 5_      `� 5`      $" Default=�6'   .1�5a      �� $# border��6&   $ ActualWidth�6;   �� 5b      $# border��6&   $ ActualHeight�6;   �� 5c      $# border��6&   $ CornerRadius�6;   �� 5d      $# border��6&   $ BorderThickness�6;   5e      5g      5h       5i      P� 5j       �@J�IsMouseOver . . �5k      �� $ border��6K    �@ Darken . 6_   5l      P� 5m       �@J�IsKeyboardFocused . . �5n      �� $ border��6K    �@ Darken . 6_   5o      P� 5p       � {� .  . �5q      ��  �@J�Opacity$
 0.23Q�60   5r      5t      5u      .��5v      � $ � RowDefinitions$ 5w   
   �� 5x      $
��auto �6   �� 5y      $	��67* �6   �� 5z      $
��533* �6   % � ColumnDefinitions% 5|   
   �� 5}      $	��250 �6   �� 5~      .+�5�   
   � -   5        & �Name$
& menu��5�      $��Stretch=�6   $��1��6=   ���	#FF373A4D$��2��6a   $ 5�      �� 5�      $��70 �6    �� 5�      $	��530 �6    .+�5�      � $��0��6   ���	#FF373A4D$��70��68   $��Bottom=�6D   .+�5�      �� $ 30��6   $��
0,0,156,10q�6+   ��5�      �� 5�      ' �� ImageSource$' icon/logo.png��6%   5�      �� 5�      $
��Left=�6   $��	94,26,0,0q�67   $
��Wrap=�6J   $	��Top=�6^   $��Yu Gothic UI Semibold)�6v   
��������� 6�   $�	GESTION D��6�   �� 6�   $	�E S��6�   �� 6�   $
�TOCK��6�   6�   5�      �� 5�      -   5        ( ��Name$( scorl��5�      $��Stretch=�6*   $��Disabled=�6H   $
��Auto=�6q   $��1��6�   $��0,5,0,0q�6�   .��5�      �� -   5        ) ��Name$
) Menu��5�      $��10q�6+   5�      5�      �� 5�   
   -   5        $) StackPanelMain��5�      $��2��6-   $��1��6:   $��Stretch=�6J   ���	#FFF8F8FA6h   � 5�   
   $��Center=�6   $��	0,0,0,529q�6,   $	��830��6?   $��1��6K   $��3��6[   ��5�      �� 5�      % 5�      �� 5�      .+�5�      �� $��Center=�6   .+�5�      '  !MaterialDesignThemes.Wpf.PopupBox  $��Right=�6+   $��10q�6G   *   PlacementMode$* BottomAndAlignRightEdges=�6T   +   	StaysOpen+ .  ,   PopupContent., 5�      �� $	��150��6!   .+�5�      �� $��Settings��6!   �� 5�      $��Account��6!   �� 5�      $
��Help��6!   �� 5�      �� 5�      -   5        - ��Name$- logout��5�   !   $��Logout��61   6B   5�      5�      5�      �� 5�      $��Button��6   $
��Left=�6&   $��650,27,0,25q�6A   $��27��6V   . J� RenderTransformOrigin$. 
0.486,0.24&�6a   $
��Auto��6�   $
 0.65Q�6�   ��5�      �� 5�      ��5�      �� 5�      ��5�      �� 5�      $' icon/bell (4).png��6!   5�      �� 5�      $�� ��6   $
��Left=�6    $��10��6;   $��
666,25,0,0q�6G   $	��Top=�6[   $��11��6s   #��� 
 6~   $. 1,1.5&�6�   ���	#FF8F0101
�������z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      / �� Angle$/ 5.259Q�6*   T� 5�      5�      ��5�      �� 5�      5�      �� 5�      -   5        0 ��Name$
0 nime��5�      $��	nime user��6&   $��722,27,46,25q�67   1 �� TextAlignment$1 Center=�6M   $��
Nirmala UI)�6d   $	 0.6Q�6|   $
��Bold"�6�   �� 5�      $�� ��6   $
��Left=�6    $��22��6;   $��
697,25,0,0q�6G   $	��Top=�6[   $��25��6s   #��� 
 6~   $. 1,1.5&�6�   ��5�      �� 5�      $!' icon/Max-R_Headshot (1).jpg��6!   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      $/ 1.074Q�6*   T� 5�      5�      ��5�      �� 5�      ��5�      �� 5�      5�      5�      5�      5�      