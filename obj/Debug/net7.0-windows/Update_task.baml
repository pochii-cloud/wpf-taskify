   M S B A M L   `   `   `  ����B  >TASKIFY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TASKIFYTASKIFY  5   	       TASKIFY.Update_task   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:TASKIFY     5   	     � Title$  Update_task��5   	   $	��450��6   $	��800��6*   ���#141625.��5	      ��  �� Padding$ 80 20q�6   ._�5
   
   �� .+�5      � $
��0 20q�6   $��Center=�6"    � ColumnDefinitions 5      �� 5      $��2* �6'   �� 5      $��* �6(   .+�5      �� -   5        $��0��5      $
��Back��6)   
����������#7C5DFA$	��100��6z   $��	0 0 100 0q�6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6    .�5      ��  �@��CornerRadius$ 15��6=   �� 5       �@��Padding$ 5q�68   5      5      5      �� 5      $��1��6   
�������$��Update Task��6?   $
��Bold"�6S   $��25(�6e   5      � 5      $��Center=�6   $
��0 20q�60   $	��400��6>    � RowDefinitions 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      .+�5&      �� $��0��6   
�������$��Task Title:��6<   $
��0 10q�6O   �� 5'      -   5         ��Name$ 
task_title��5'   '   $��1��6   
������ ���#7C5DFA$�� 0 0 0 2q�6j   
�������6�   �� 5(      $��2��6   
�������$��Task Description:��6<   $
��0 10q�6U   �� 5)      -   5        $ task_description��5)   '   $��3��6   
������ ���#7C5DFA$�� 0 0 0 2q�6p   
�������6�   �� 5*      -   5        $��5��5*      $��Update Task��6&   
����������#7C5DFA$
��0 10q�6d    5+      ��%�   '��       �� 5,      " ��6    .�5-      ��  �@��CornerRadius$ 5��6=   �� 5.       �@��Padding$ 5q�68   50      51      52      53      54      55      56      