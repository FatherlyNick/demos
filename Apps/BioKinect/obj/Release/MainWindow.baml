   M S B A M L   `   `   `  ����   	BioKinect    BioKinect.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     _ [Microsoft.Kinect.Toolkit, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35h dMicrosoft.Kinect.Toolkit.Controls, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e352k(http://schemas.microsoft.com/kinect/2013   -     � Title$  	BioKinect��$
��1200�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowState$ 	Maximized=�
���   �
�������.��� -   $��
layoutGrid��$��0 0 0 0q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto ��� $
��Auto �.+�]� $��	10,0,10,0q�.+�4  .Microsoft.Kinect.Toolkit.KinectSensorChooserUI  -   $��sensorChooserUi��$��38��$��49��$��Center=�$	��Top=�(� $��1�� (� Stretch$ Uniform=�$��Center=�.���� -   $��Image��$	��640��$	��655��� $	��Top=�$��74��$
��Left=�$	��400��.+��� -   $��advancedDebugMode��$��18��$	��150��$��Right=�$��	0,16,0,40q�
�������$
��Bold"�.��Advanced Debug mode�� -   $��	debugMode��$��18��$	��150��$��Right=�$��0,1,0,55q�
�������$
��Bold"�.��
Debug Mode�� -   $��legMode��$��18��$	��150��$��Right=�$��	0,31,0,25q�
�������$
��Bold"�.��
Lower Legs�� -   $��	timerMode��$��18��$	��150��$��Right=�$��	0,46,0,10q�
�������$
��Bold"� d� 	IsChecked$
 TrueY�.��Timer�� -	   $��jointCoords��$��10(� �� TextAlignment$ Justify=�$
��Wrap=�$
��Left=�$	��250��$	��200��� $��Center=�$	��350��$��35��.+��� -
   $��requestedBone��$
��Bold"�$��18(�$��Right=�$��30��$	��272��
���  ���� -   $��requestedBoneLabel��$��32��$
��Bold"�$��16(�
�������$
��Left=�.��	Point at:�� $��Segoe UI)�$��18(�$��85��$��24��
�������$
��Bold"�$��Right=�	BioKinect� -   $��	scoreArea��$	��200��$��32��$��Right=�$	��Top=�.+��� -   $��
scoreBoard��$��35��$��Center=�$��Center=�$
��Bold"�$��22(�
���  ���� -   $��
scoreLabel��$
��Left=�$��Center=�$
��Bold"�$��14(�
�������.��Score:� -   $��	timerArea��$	��200��$��Right=�$��Bottom=�$��32��.+��� -   $��timerWindow��$��35��$
��Bold"�$��22(�$��Center=�$��67��$��0,0,0,-3q�
���  ���� -   $��
timerLabel��$��24��$
��Bold"�$��13(�$��68��$
��Left=�
�������.��
Time left: