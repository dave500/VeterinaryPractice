   M S B A M L   `   `   `  ����F  BPetReporter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PetReporter.ViewsPetReporter.Views  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	   "    PetReporter.Views.ReportView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PetReporter.Views     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   ^ ZCaliburn.Micro.Platform, Version=3.2.0.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5	        � Title$  	OwnerView��5
   	   $	��450��6   $	��800��6(   
 � Top$	 200��64    � Left$	 200��6>    � 
ResizeMode$ NoResize=�6I    � WindowStyle$ SingleBorderWindow=�6_   .��5      �  � ColumnDefinitions 5   
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
SubTitle+5$      5&      � 5*   
   $��2��6   $��2��6   $��4��6,   $��20,20,20,20q�6@   .+�5+      &   System.Windows.Controls.DataGrid  -   5          Name$ Animals��5+         AlternatingRowBackground
 �����	   AutoGenerateColumns	 .  
   Columns
 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Full Name��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   ��  �� Path$ FullName�  5.      $ Joined Practice��6)    6B   �� $ JoinedPractice� �� StringFormat$ 
yyyy/MM/dd��  5/      $ Animal Name��6)    6>   �� $ 
AnimalName�  50      $ Species��6)    6:   �� $
 Type�  51      $ Number Of Visits��6)    6C   �� $ NumberOfVisits�  52      $ Cost Per Visit��6)    6A   �� $ CostPerVisit�  53      $ 	Character��6)    6<   �� $ 	Behaviour�55      56      �� 59   
   $��3��6   $��2��6   $��
Export csv��6F   $��10q�6[   $��30��6g   $	��100��6s    � DataContext 6.   �� .  (System.Windows.Interactivity.Interaction   Triggers 5:      /  )System.Windows.Interactivity.EventTrigger  5;         	EventName$ Click��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5<      "  Caliburn.Micro.ActionMessage     
MethodName$ 	ExportCSV��6(   5=      5?      �� 5A   
   $��Center=�6   $��3��6-   $��3��6:   $��2��6J   $	��300��6^   $��	10,0,10,0q�6j   ._�5B      �� $��15(�6   $��Medium"�6'   ��6;   �� *ReportColour+��6_   �� *ReportMessage+6�   5C      �� 5E   
   $��3��6   $��5��6   $
��Home��6F   $��10q�6U   $��30��6a   $	��100��6m    6.   ��  5F        5G      $ Click��6!   . 5H        $ 
ReturnHome��6(   5I      5K      5M      5N      