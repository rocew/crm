   M S B A M L   `   `   `  ����>  :CRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CRM.ElementsCRM.Elements  5          CRM.Elements.Item   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:CRM.Elements     5      .��5      ��   �� CornerRadius$  10��6   $��	10,5,10,5q�6   ���#1C1C1C._�5	   
   �  � ColumnDefinitions 5
      �� 5      $	��190 �6#   �� 5      $��1* �6#   �� 5      $��1* �6#   .+�5      �� $��3q�6   ���#39393B$  30��6?   $	��150��6Q   $	��150��6]   $��20,20,20,20q�6j   $
��Left=�6   $	��Top=�6�   $��0��6�   ��5      �� 5       �� ImageSource$( "C:\Users\kokes\Downloads\i-_3_.jpg��6!    j� Stretch$ UniformToFill=�6R    J� Clip 5      �� 5       �� Rect$ 0,0,150,150�6(    �� RadiusX$ 30Q�6;    �� RadiusY$ 30Q�6H   5      � 5      $��1��6   $��10,20,10,20q�6#   .+�5      �� $1��+Фамилия, Имя и Отчество:��6   ���#FFF$��18(�6M   $
��Left=�6[   $	��Top=�6v   �� 5      -   5         ��Name$	 FIO��5      $,��&Иванов Иван Иванович��6%   ���#FFF$��16(�6V   $
��Left=�6d   $	��Top=�6   $��0,30,0,0q�6�   �� 5      $��Пол:��6   ���#FFF$��18(�69   $
��Left=�6G   $	��Top=�6b   $��0,60,0,0q�6z   �� 5      -   5        $ gender��5      $��Мужской��6(   ���#FFF$��16(�6L   $
��Left=�6Z   $	��Top=�6u   $��0,90,0,0q�6�   �� 5      $!��Специализация:��6   ���#FFF$��18(�6C   $
��Left=�6Q   $	��Top=�6l   $��	0,120,0,0q�6�   �� 5      -   5        $ specialization��5      $��Программист��60   ���#FFF$��16(�6X   $
��Left=�6f   $	��Top=�6�   $��	0,150,0,0q�6�   5      � 5!      $��2��6   $��
10,20,10,0q�6#   .+�5"      �� $ ��Дата рождения:��6   ���#FFF$��18(�6C   $
��Left=�6Q   $	��Top=�6l   �� 5#      -   5        $ 
birth_date��5#      $,��&Иванов Иван Иванович��6,   ���#FFF$��16(�6]   $
��Left=�6k   $	��Top=�6�   $��0,30,0,0q�6�   �� 5$      $��Пол:��6   ���#FFF$��18(�69   $
��Left=�6G   $	��Top=�6b   $��0,60,0,0q�6z   �� 5%      -   5        $	 age��5%      $��Мужской��6%   ���#FFF$��16(�6I   $
��Left=�6W   $	��Top=�6r   $��0,90,0,0q�6�   �� 5&      $0��*Контактная информация:��6   ���#FFF$��18(�6K   $
��Left=�6Y   $	��Top=�6t   $��	0,120,0,0q�6�   �� 5'      -   5        $ contact��5'      $��Программист��6)   ���#FFF$��16(�6Q   $
��Left=�6_   $	��Top=�6z   $��	0,150,0,0q�6�   5(      �� 5*      -   5        $�� ��5*      $��25��6    $��25��6+   
������ ���#FFF$��Right=�5-      $	��Top=�5.      $��2��5/   /   ��50      �� 51      	 �� 
TargetType"	 ��6&   .R�52      � .+�54      �� 	
 �� X1$
 0��6#   	 �� Y1$ 0��6*   	 �� X2$ 0��61   	 �� Y2$ 30��68   ���#39393B$��2��6Q   �� 56      $
 0��6#   $ 25��6*   $ 25��62   $ 25��6:   ���#39393B$��2��6S   �� 5:      $
 5��6#   $ 5��6*   $ 20��61   $ 20��69   ���#FFF$��2��6O   �� 5;      $
 20��6#   $ 5��6+   $ 5��62   $ 20��69   ���#FFF$��2��6O   5<      5=      5?      5@      5A      5B      