   M S B A M L   `   `   `  ����B  >TASKIFY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TASKIFYTASKIFY  5   	       TASKIFY.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:TASKIFY     5   	   $	��450��5   
   $	��600��6   ���#141625.��5      ��   �� Padding$  80 20q�6   ._�5   
   �� .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6   $��TASKIFY��6,   
�������$
��Bold"�6N   $��20(�6`   �� 5      -   5        $��1��5      $��Add Task��6)   
����������#7C5DFA � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6    .�5      ��  �@��CornerRadius$ 15��6=   �� 5       �@��Padding$ 5q�68   5      5      5      5      �� 5!      -   5         ��Name$ taskListBox��5!      ���#1E2139$��0q�6@   $
��0 20q�6�   ��5"      �� 5#      .R�5$      � ���#1E2139$	��0 5q�64    5%      �� 5&   "   �� 5'   "   �� 5(   "   �� 5)   "   �� 5*   "   .+�5,      �� $��0��6(   
������� �� Padding$	 5 5q�6b   ��68   �� *title+6b   �� 5-      $��1��6(   
�������$	 5 5q�6h   ��68   �� *description+6h   �� 5.      $��2��6$   ��5/   "   �� 50   &   " ��6,   .�51   *   ��  � ��$ Not Complete��6D   �� 52   *    � ��
 �  ��6G    �� Triggers 53   *   �� 54   .   	 �� Binding	 6:   �� *is_complete+
 �� Value
 True6Z   .a�55   2   ��  � ��$ 	Completed��6L   �� 56   2    � ��
 � � �6O   57   /   59   '   5;      �� 5>      -   5        $��3��5>   %   $��delete��65   
�������
���  ��$	��5 0q�6�   
 � Tag 6�   �� *id+6�   �� 5?      -   5        $��4��5?   %   $��update��65   
�������
����  �$	��5 0q�6�    6�   �� *id+6�   5B      5C      5E      5H      5I      5J      