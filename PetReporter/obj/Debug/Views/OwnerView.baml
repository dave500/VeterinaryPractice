   M S B A M L   `   `   `  ����F  BPetReporter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PetReporter.ViewsPetReporter.Views  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	   !    PetReporter.Views.OwnerView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PetReporter.Views     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   ^ ZCaliburn.Micro.Platform, Version=3.2.0.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5	        � Title$  	OwnerView��5
   	   $	��450��6   $	��800��6(    � 
ResizeMode$ NoResize=�64    � WindowStyle$ SingleBorderWindow=�6J   
 � Top$	 200��6k    � Left$	 200��6u   .��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   � $��1��6   $��7��6   $��0,0,0,20q�60   .+�5      �� $��/Images/ASPitch-lg.png��6   �� 5      $��Center=�6   ._�5       �� $��5,2,5,2q�6   $��30(�6.   $��Medium"�6<   
���������6c   �� *Title+5!      �� 5"      $��Bottom=�6   ._�5#      �� $��5,2,5,2q�6   $��15(�6.   $��Medium"�6<   
���������6c   �� *
SubTitle+5$      5&      �� 5*   
   $��Center=�6   $��2��6-   $��2��6:   $	��120��6J   $��	10,0,10,0q�6V   ._�5+      �� $��15(�6   $��Medium"�6&   ��6:   �� *
OwnerLabel+6X   5,      �� 5.   
   -   5         ��Name$ Owners��5.   0   $��2��6   $��3��6    $��10,20,20,20q�6@    �� DisplayMemberPath$ FullName��50      	 �� SelectedItem	 5/      �� 
 �� Path$
 SelectedOwner� �� Mode$ OneWayToSource=�50      �� 52   
   $��2��6   $��5��6"   $��2��62   .+�53   
   �� $��Select User��6   $��10,20,10,10q�6'   $��30��6<   $	��100��6H   .  (System.Windows.Interactivity.Interaction   Triggers 54      /  )System.Windows.Interactivity.EventTrigger  55         	EventName$ Click��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 56      "  Caliburn.Micro.ActionMessage     
MethodName$ LoadReportDetails��6(   57      59      �� 5;   
   $��
Select All��6   $��10q�6&   $��30��62   $	��100��6>    5<        5=      $ Click��6!   . 5>        $ LoadReportDetails��6(   5?      5A      5B      5D      5E      