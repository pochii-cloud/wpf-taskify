   M S B A M L   `   `   `  ����B  >TASKIFY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TASKIFYTASKIFY  5   	       TASKIFY.AddTask   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:TASKIFY     5   	     � Title$  AddTask��5   	   $	��450��6   $	��800��6&   ���#141625.��5	      ��  �� Padding$ 80 20q�6   ._�5
   
   �� .+�5      �  � ColumnDefinitions 5      �� 5      $��2* �6'   �� 5      $��* �6(   .+�5      �� -   5        $��0��5      $
��Back��6)   
����������#7C5DFA$	��100��6z   $��	0 0 100 0q�6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6    .�5      ��  �@��CornerRadius$ 15��6=   �� 5       �@��Padding$ 5q�68   5      5      5      �� 5      $��1��6   
�������$��Add Task��6?   $
��Bold"�6P   $��25(�6b   5      � 5      $��Center=�6   $
��0 20q�60   $	��400��6>    � RowDefinitions 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      �� 5$      .+�5(      �� $��1��6   
�������$��Task Title:��6<   $
��0 10q�6O   �� 5)      -   5         ��Name$ title��5)      $��2��6)   
������ ���#7C5DFA$�� 0 0 0 2q�6e   
�������6�   �� 5*      $��3��6   
�������$��Task Description:��6<   $
��0 10q�6U   �� 5+      -   5        $ description��5+      $��4��60   
������ ���#7C5DFA$�� 0 0 0 2q�6l   
�������6�   �� 5,      -   5        $��5��5,      $��Add Task��6&   
����������#7C5DFA$
��0 10q�6a    5-      ��%�   '��       �� 5.      " ��6    .�5/      ��  �@��CornerRadius$ 5��6=   �� 50       �@��Padding$ 5q�68   52      53      54      55      56      57      58      