   M S B A M L   `   `   `  ����S  OAcademicCircleManagerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AcademicCircleManagerApp.Properties#AcademicCircleManagerApp.Properties  5      O,clr-namespace:AcademicCircleManagerApp.ViewsAcademicCircleManagerApp.Views  5      3    -AcademicCircleManagerApp.Views.MemberListForm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Bresx1clr-namespace:AcademicCircleManagerApp.Properties     5      >local,clr-namespace:AcademicCircleManagerApp.Views     5      ���	#FFFFF5F5  � 	Resources  5       �� 
TargetType �� Property �� Value �� EndPoint �� 
StartPoint � Color � Offset��%�  '��       �� 5   
   " ��6   .�5      ��  � ��$ Charlesworth)�6+   �� 5       � ��$ 18(�6)   �� 5       � ��$ Center=�64   �� 5       � ��$ 30��6'   �� 5       � ��$	 150��6&   �� 5       � ��
 �����6+   �� 5       � �� 5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $ MediumPurple��6'   $ 0.421Q�6<   � 5      $ MediumPurple��6'   $ 1Q�6<   5      5      5      5      .��5      � ���	#FFF6F6F6 � ColumnDefinitions 5   
   �� 5       $��0.15* �6   �� 5!      $
��0.5* �6   �� 5"      $
��0.5* �6   �� 5#      $��0.15* �6   	 � RowDefinitions	 5'   
   �� 5(      $��0.12* �6   �� 5)      $��0.30* �6   �� 5*      $��0.30* �6   �� 5+      $��0.12* �6   .+�5-   
   �� $��0��6   $��4��6"   ��5.      �� 5/      $ 0.5,1&�6&   $ 0.5,0&�67   .��50      � $ White��6#   $ 0.421Q�61   � 51      $ White��6#   $ 1Q�61   52      .+�55      �� $	��Top=�6T   $
��Left=�6l   $��26(�6�   $��SemiBold"�6�   $��15q�6�   
����p����6   �� 3   -AcademicCircleManagerApp.Properties.Resources
   
MemberList �� Source# Z
 6�   �� 56      $	��Top=�6O   $��Right=�6g   $��26(�6�   $��SemiBold"�6�   
����p��$��55,-55q�6�   
�������$��0q�57   (   $	��100��6\   ��56      ��    Menu# Z ��57   <   �� *GotoWelcome+6\   59      �� 5;   
   $��1��6   $��4��6&   $��1��6:   $	��340��6G   $	��Top=�6U   $��
-90,0,10,0q�6m   .+�5<      �� $	��340��6   $��12(�6l   ��6$   �� *	Members+ �� SelectedItem 6D   �� *SelectedMember+ �� View 5=      �� 5>      .P�5?      ��  �� Width$	 200��6i   ��6*   ��    
FirstName1# Z  �� DisplayMemberBinding 6u   �� *	FirstName+�� 5@      $	 200��6i   ��6+   ��    	LastName1# Z  6v   �� *
LastName+�� 5A      $	 200��6d   ��6*   ��    Year1# Z  6p   �� *Year+�� 5B      $	 330��6g   ��6*   ��    Faculty1# Z  6s   �� *	Faculty+5C      5E      5F      �� 5G   
   $��1��6   $��4��6%   $��2��69   $	��340��6F   $	��Top=�6T   $��-90,10,10,0q�6m   .+�5H      �� |�.  $	��340��6(    �� TextWrapping$
 Wrap=�6a   ��65   �� *MemberDetails+ �� Mode$ OneWay=�6a   5I      �� 5K      $��3��6   $��0��6&   $��4��66   .+�5L      �� $��-600,20,20,0q�6N   $	��250��6�   ��6   �� 
   Add# Z ��6d   �� *GotoAddMember+6�   �� 5N      $��2��6   $��	0,-30,0,0q�6\   $	��250��6�   ��6"   ��    Edit# Z ��6o   �� *GotoEditMember+6�   �� 5P      $��2��6   $��600,-30,0,0q�6^   $	��250��6�   ��6"   ��    Delete# Z ��6s   �� *DeleteMember+6�   5R      5S      5T      