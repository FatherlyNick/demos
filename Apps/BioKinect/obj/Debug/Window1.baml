   M S B A M L   `   `   `  ����  	BioKinect    BioKinect.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _ [Microsoft.Kinect.Toolkit, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35h dMicrosoft.Kinect.Toolkit.Controls, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e352k(http://schemas.microsoft.com/kinect/2013   5   	     � Title$  	Main Menu��5   	   $	��700��6   $	��900��6(   
 � Top$	 100��64   $��Center=�6>   $��Center=�6[    � WindowStartupLocation$ CenterScreen=�6v    � 
ResizeMode$ NoResize=�6�    � WindowState$ 	Maximized=�6�   .��5      � ��6   Z� .+�5   
   8  2Microsoft.Kinect.Toolkit.Controls.KinectUserViewer  $	��Top=�6   $��Center=�65   $��86��5   N   $��395,0,386,0q�6q   $��97��6�   4  .Microsoft.Kinect.Toolkit.Controls.KinectRegion   KinectRegion 6   ��  �� ElementName$ kinectRegion�� J� OpacityMask 6Z   Z� 6�     5	   
   -   5        $��kinectRegion��5	      .��5
      � .+�5      � -   5        $��playInstructionsGrid��5      $
��Left=�63   $	��320��6N   $	��460��6Z   $��Bottom=�6g   
���  ��.+�5      �� $��Center=�6   $	��top=�69   $
��Bold"�6Q   $��	Agency FB)�6c   $��35(�6z   
�������.��6�   How to play6�   :  4Microsoft.Kinect.Toolkit.Controls.KinectScrollViewer  5      -   5        $��instructionsScroller��5   +   $	��400��6G   $��Bottom=�6T   
���   �.��5      � .+�5      �� -   5        $��gameInstructions��5   (   $
��Wrap=�6@   $��	15,0,10,0q�6T   
�������$��18(�6z   6�   5      5      5      8  2Microsoft.Kinect.Toolkit.Controls.KinectTileButton  5      -   5           Label$ Play BioKinect��5   %   $��Center=�6<   $��Center=�6q   	   VerticalLabelAlignment$	 Center=�6�   $
��Bold"�6�   $��40(�6�   
���  ��
�������
�������
   LabelBackground

 �  ��$��	Agency FB)�6  63  � 5      -   5        $��diffGrid��5      $	��320��6'   $	��460��63   $��Bottom=�6@   $��Right=�6[   
���  ��.+�5      �� $��35��6   $
��Bold"�6(   $��	Agency FB)�6:   $��23(�6Q   $��Center=�6_   $	��Top=�6�   
�������
���  ��.��6�   Difficulty Level6�   � 5      $
��Left=�6   $	��300��66   $��55��6C   .+�5      �� $��30��6    $
��Left=�6,   $	��Top=�6G   $
��Bold"�6_   
�������$��18(�6�   $��	Agency FB)�6�   .��6�   Easy6�   �� 5      $��30��6    $
��Left=�6,   $��Center=�6G   $
��Bold"�6b   
�������$��18(�6�   $��	Agency FB)�6�   .��6�   Medium6�   �� 5      $��30��6    $
��Left=�6,   $��Bottom=�6G   $
��Bold"�6b   
�������$��18(�6�   $��	Agency FB)�6�   .��6�   Hard6�   5      � 5      -   5        $��diffButtons��5      $��Center=�6.   $	��100��6K   $	��400��6W   .+�5      :  4Microsoft.Kinect.Toolkit.Controls.KinectCircleButton  -   5        $	��150��5   /   $	��Top=�6<   
�������6|     5      -	   5        $	��150��5   /   $��Center=�6<   
�������6�     5       -
   5        $	��150��5    /   $��Bottom=�6<   
�������6~   5!      � 5#      -   5        $��ticks��5#      $��Center=�6(   $��Right=�6C   $��70��6_   $	��300��6j   .+�5$      �� -   5        $��difficultyTick��5$   $   
�������$
��Bold"�6M   $��	Agency FB)�6_   $��28(�6v   $	��<<<��6�   6�   5&      5(        5)      -   5        $ Learn��5)   %   $��Right=�63   $	��100��6n   $	��100��6z   $��20(�6�   $
��Bold"�6�   
���  ��
�������

 �  ��$��	Agency FB)�6  $��0,10,22,351q�6&  ��6�   Z�  6�   Z� 6=  ��5*      �� 5+       �� ImageSource$1 +/BioKinect;component/Images/BioKinect_1.png��6!    j� Stretch$
 Fill=�6[    j� TileMode$
 None=�6j   5-      5.      4  .Microsoft.Kinect.Toolkit.KinectSensorChooserUI  5/   
   -   5        $��sensorChooserUi��5/   W   $��Center=�6"   $	��Top=�6?   $��421,0,417,0q�6�   ��6n   Z� ��6�   Z� 6�   50      52      