   M S B A M L   `   `   `  ����S  OAcademicCircleManagerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AcademicCircleManagerApp.Properties#AcademicCircleManagerApp.Properties  5      O,clr-namespace:AcademicCircleManagerApp.ViewsAcademicCircleManagerApp.Views  5      Y1clr-namespace:AcademicCircleManagerApp.ViewModels#AcademicCircleManagerApp.ViewModels  5	      3    -AcademicCircleManagerApp.Views.SpecialistForm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      <resx1clr-namespace:AcademicCircleManagerApp.Properties  5      8local,clr-namespace:AcademicCircleManagerApp.Views  5      :vm1clr-namespace:AcademicCircleManagerApp.ViewModels  5	      .  (System.Windows.Interactivity.Interaction    Triggers  5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Closing��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   ��  �� ElementName$ GridRoot�� �� Path$ DataContext.Write�5       � 	Resources 5       �� 
TargetType �� Property	 �� Value
 �� EndPoint �� 
StartPoint � Color � Offset��%�  '��       '�� �     '�� �    '�� #    �� 5   
   " ��6   .�5      ��  � ��$	 Charlesworth)�6+   �� 5       � ��$	 SemiBold"�6+   �� 5       � ��$	 18(�6)   �� 5       � ��$	 Right=�64   5      �� 5   
   " ��6   .�5      ��  � ��$	 Charlesworth)�6+   �� 5       � ��$	 18(�6)   �� 5       � ��$		 180��6&   �� 5        � ��$	 30��6'   �� 5!       � ��
	 �����6+   �� 5"       � ��$		 Top=�62   �� 5#       � ��$	 2��6)   �� 5$       � ��	 5%      �� 5&      $
 0.5,1&�6*   $ 0.5,0&�6;   .��5'      � $ MediumPurple��6'   $ 0.421Q�6<   � 5(      $ MediumPurple��6'   $ 1Q�6<   5)      5+      5,      �� 5.   
   " ��6   .�5/      ��  � ��$	 Cornerstone)�6+   �� 50       � ��$	 DemiBold"�6+   �� 51       � ��$	 Center=�69   �� 52       � ��$		 250��6&   �� 53       � ��$	 25��6'   �� 54       � ��$
	 Left=�64   �� 55       � ��$		 2.5q�60   �� 56       � ��
	 ��p��6,   57      �� 59   
   " ��6   .�5:      ��  � ��$	 Cornerstone)�6+   �� 5;       � ��$	 DemiBold"�6+   �� 5<       � ��$	 Center=�69   �� 5=       � ��$		 250��6&   �� 5>       � ��$	 25��6'   �� 5?       � ��$
	 Left=�64   �� 5@       � ��$		 2.5q�60   �� 5A       � ��
	 ��p��6,   5B      5D      .��5F      � ���	#FFF6F6F6 � ColumnDefinitions 5G   
   �� 5H      $��0.15* �6   �� 5I      $��0.35* �6   �� 5J      $��0.15* �6   �� 5K      $��0.35* �6    � RowDefinitions 5O   
   �� 5P      $��0.12* �6   �� 5Q      $��0.60* �6   �� 5R      $��0.12* �6   .+�5T   
   �� $��0��6   $��4��6"   ��5U      �� 5V      $
 0.5,1&�6&   $ 0.5,0&�67   .��5W      � $ MediumPurple��6#   $ 0.421Q�68   � 5X      $ MediumPurple��6#   $ 1Q�68   5Y      .+�5\      �� $	��Top=�6R   $
��Left=�6j   $��26(�6�   $��SemiBold"�6�   $��Charlesworth)�6�   $��15q�6�   ���	#FFEEEAEA��6   �� 3   -AcademicCircleManagerApp.Properties.Resources   YourData �� Source# Z 6�   �� 5]      $	��Top=�6_   $��Right=�6w   $��26(�6�   $��SemiBold"�6�   $��Charlesworth)�6�   ���	#FFEEEAEA$��0,-55,55,-55q�6�   
������ $��0q�5^      $��40��6)   ��5]      ��    AcademicCircleManager# Z 5^   )   5_      �� 5`   
   $
��Left=�6   $��	0,40,0,64q�61   $��1��6D   $��1��6Q   $��0��6e   $��2��6u   $	��135��6�   .+�5b      �� $��30,0,0,0q�6S   ��6   ��    	FirstName# Z 6S   �� 5c      $��10,0,0,0q�6R   ��6   ��    LastName# Z 6R   �� 5d      $��10,0,0,0q�6Q   ��6   ��    Faculty# Z 6Q   �� 5e      $��10,0,0,0q�6\   ��6   ��    ShortNameOfFaculty# Z 6\   5h      �� 5i   
   $
��Left=�6   $��	0,40,0,64q�61   $��1��6D   $��1��6Q   $��1��6e   $��2��6u   $	��296��6�   .+�5j      �� $��10,2,0,0q�6   ��6(   �� *	FirstName+�� 5k      $��10,7,0,0q�6   ��6(   �� *
LastName+�� 5l      $��10,7,0,0q�6   ��6(   �� *FacultyName+�� 5m      $��10,7,0,0q�6   ��6(   �� *ShortFacultyName+5n      �� 5o   
   $
��Left=�6   $��322,27,0,77q�61   $��1��6F   $��1��6S   $��2��6c   $	��160��6t   $��3��6�   .+�5p      �� $��10,0,0,0q�6Q   ��6   ��    ZipCode# Z 6Q   �� 5q      $��10,0,0,0q�6N   ��6   ��    City# Z 6N   �� 5r      $��10,0,0,0q�6P   ��6   ��    Street# Z 6P   �� 5s      $��10,0,0,0q�6P   ��6   ��    Number# Z 6P   �� 5t      $��10,0,0,0q�6V   ��6   ��    SecondNumber# Z 6V   5u      �� 5v   
   $��3��6   $��	2,24,0,62q�6%   $
��Left=�68   $	��300��6S   $��2��6_   $��1��6p   .+�5w      �� $
��10,7q�6   ��6$   �� *	ZipCode+�� 5x      $
��10,0q�6   ��6$   �� *City+�� 5y      $
��10,7q�6   ��6$   �� *Street+�� 5z      $
��10,0q�6   ��6$   �� *Number+�� 5{      $
��10,7q�6   ��6$   �� *SecondNumber+5}      �� 5   
   $��1��6   $��2��6!   $��Zapisz��65   $
��Left=�6F   $��	272,0,0,0q�5�   ,   $��2��6?   ��6   �� *Accept+5�      5�      5�      