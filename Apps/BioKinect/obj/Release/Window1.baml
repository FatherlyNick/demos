   M S B A M L   `   `   `  ����   	BioKinect    BioKinect.Window1   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     _ [Microsoft.Kinect.Toolkit, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35h dMicrosoft.Kinect.Toolkit.Controls, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e352k(http://schemas.microsoft.com/kinect/2013     � Title$  	Main Menu��$	��700��$	��900��
 � Top$	 100��$��Center=�$��Center=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowState$ 	Maximized=�.��� ��Z� .+�8  2Microsoft.Kinect.Toolkit.Controls.KinectUserViewer  $	��Top=�$��Center=�$��86��$��395,0,386,0q�$��97��4  .Microsoft.Kinect.Toolkit.Controls.KinectRegion   KinectRegion ��  �� ElementName$ kinectRegion�� J� OpacityMask Z�   -   $��kinectRegion��.��� .+�� -   $��playInstructionsGrid��$
��Left=�$	��320��$	��460��$��Bottom=�
���  ��.+��� $��Center=�$	��top=�$
��Bold"�$��	Agency FB)�$��35(�
�������.��How to play:  4Microsoft.Kinect.Toolkit.Controls.KinectScrollViewer  -   $��instructionsScroller��$	��400��$��Bottom=�
���   �.��� .+��� -   $��gameInstructions��$
��Wrap=�$��	15,0,10,0q�
�������$��18(�8  2Microsoft.Kinect.Toolkit.Controls.KinectTileButton  -      Label$ Play BioKinect��$��Center=�$��Center=�	   VerticalLabelAlignment$	 Center=�$
��Bold"�$��40(�
���  ��
�������
�������
   LabelBackground

 �  ��$��	Agency FB)�� -   $��diffGrid��$	��320��$	��460��$��Bottom=�$��Right=�
���  ��.+��� $��35��$
��Bold"�$��	Agency FB)�$��23(�$��Center=�$	��Top=�
�������
���  ��.��Difficulty Level� $
��Left=�$	��300��$��55��.+��� $��30��$
��Left=�$	��Top=�$
��Bold"�
�������$��18(�$��	Agency FB)�.��Easy�� $��30��$
��Left=�$��Center=�$
��Bold"�
�������$��18(�$��	Agency FB)�.��Medium�� $��30��$
��Left=�$��Bottom=�$
��Bold"�
�������$��18(�$��	Agency FB)�.��Hard� -   $��diffButtons��$��Center=�$	��100��$	��400��.+�:  4Microsoft.Kinect.Toolkit.Controls.KinectCircleButton  -   $	��150��$	��Top=�
�������  -	   $	��150��$��Center=�
�������  -
   $	��150��$��Bottom=�
�������� -   $��ticks��$��Center=�$��Right=�$��70��$	��300��.+��� -   $��difficultyTick��
�������$
��Bold"�$��	Agency FB)�$��28(�$	��<<<��  -   $ Learn��$��Right=�$	��100��$	��100��$��20(�$
��Bold"�
���  ��
�������

 �  ��$��	Agency FB)�$��0,10,22,351q���Z�  Z� ����  �� ImageSource$1 +/BioKinect;component/Images/BioKinect_1.png�� j� Stretch$
 Fill=� j� TileMode$
 None=�4  .Microsoft.Kinect.Toolkit.KinectSensorChooserUI  -   $��sensorChooserUi��$��Center=�$	��Top=�$��421,0,417,0q���Z� ��Z� 