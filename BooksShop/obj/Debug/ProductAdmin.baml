   M S B A M L   `   `   `  ����D  @BooksShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BooksShop	BooksShop  5          BooksShop.ProductAdmin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:BooksShop     5        N� Title$"  Данные о товаре��5	      $	��450��6!   $	��800��6.    N� 
Background
 �����.��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��1��6   $"��Данные о товаре��6$   $��Center=�6;   $��Center=�6V   $	��300��6s   $��20(�6    �� TextAlignment$ Center=�6�   �� 5   
   $��1��6   $��Center=�6!   $	��200��6<   $��20��6H   $#��Название товара��6T   $��15(�6k   $ Center=�6y   �� 5   
   -   5        $��NameProduct��5   R   $��1��6   $��Bottom=�6   $	��200��6:   $��30��6F   6R   �� 5   
   $��2��6   $��Center=�6!   $	��200��6<   $��20��6H   $��Тип товара��6T   $��15(�6f   $ Center=�6t   �� 5   
   -   5        $��CBTypeProduct��5   S   $��2��6   $��Bottom=�6    $	��200��6;   $��30��6G   5      �� 5   
   $��3��6   $��Center=�6!   $	��200��6<   $��20��6H   $-��'Страна производителя��6T   $��15(�6p   $ Center=�6~   �� 5    
   -   5        $��CBManufProduct��5    T   $��3��6   $��Bottom=�6    $	��200��6;   $��30��6G   5!      �� 5#   
   -   5        $��Insert��5#   �   $��1��6   $��2��6   $��Center=�6/   $��Center=�6J   $	��200��6g   $��30��6s   
���r���$!��Добавить товар��6�   $��15(�6�   
�������6�   �� 5$   
   -   5        $��Update��5$   �   $��2��6   $��2��6   $��Center=�6/   $��Center=�6J   $	��200��6g   $��30��6s   
���r���$!��Изменить товар��6�   $��15(�6�   
�������6�   �� 5%   
   -   5        $��Delete��5%   �   $��3��6   $��2��6   $��Center=�6/   $��Center=�6J   $	��200��6g   $��30��6s   
���r���$��Удалить товар��6�   $��15(�6�   
�������6�   �� 5&   
   -   5        $
��Exit��5&   �   $	��Top=�6   $
��Left=�6+   $	��120��6F   $��30��6R   
���r���$��
Выход��6r   $��15(�6�   
�������6�   �� 5'   
   -   5         ��Name$ DataGrid��5'   E   $��4��6   $��3��6    $��2��64   ��5(      �� 5*      .R�5+      �  5,      �� 5-      $	��300 �6/   �� 5.      $	��400 �6/   �� 5/      $	��300 �6/    � ContextMenu 52      �� 53      .@�54   "   m� $��InsOrder��6F   -	   5        $%�� Добавить в заказ��54   +   6V   55      .+�57      �� .+�58      �� $#��Название товара��6(   $��Center=�6?   �� 59      $��Center=�6I   ��6(   �� *Название_товара+6I   5;      �� 5<      $��1��6%   .+�5=      �� $��Тип товара��6(   $��2��6:   $��Center=�6J   $ Center=�6g   �� 5>      $��Center=�6D   ��6(   �� *Тип_товара+6D   5?      �� 5@      $��2��6%   .+�5A      �� $-��'Производитель товара��6(   $��Center=�6D   �� 5B      $ Center=�6N   ��6(   �� *)'Страна_производителя+6N   5C      5D      5E      5G       � 5H   
   -
   5        $��Exits��5H   5   $��6��6   $��3��6!   65   5K      5L      