   M S B A M L   `   `   `  ����M  IEmployeeFaceCapure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:EmployeeFaceCapureEmployeeFaceCapure  5   	   *    $EmployeeFaceCapure.AddEmployeeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:EmployeeFaceCapure     5   	     � Title$  Add Employee��5   	   $	��550��6   $	��800��6+   .��5
      ��  �� Padding$ 20q�6   ._�5   
   �� .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��0��6   .+�5      �� .+�5      �� $��Captured Image��6$    �� TextAlignment$ Center=�6:   $
��Bold"�6Q   5      �� 5      $	��312��6!   .+�5      �� $	��200��6   $	��200��6+   �� 5      -   5        $��Start Capture��5   !   $��18(�69   $
��Bold"�6G   $��10q�6Y   $��0 0 10 0q�6f   
����·�$��0q�6�   $	��258��6�   6�   5      �� 5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgView��5   #   $	��182��6`   5      5       �� 5"      $��1��6   .+�5#      �  5$      �� 5%      $��* �6/   �� 5&      $��2* �6/   .+�5)      ��  �� Padding$
 0 10q�6$   $
��Name��63   $��0��6?   $��18(�6O   $
��0 10q�6]   �� 5*      -   5         ��Name$ txtName��5*   "   $��1��63   $��10q�6C   $
��0 10q�6P   5,      � 5-       5.      �� 5/      $��* �6/   �� 50      $��2* �6/   .+�53      �� $
 0 10q�6$   $
��0 10q�63   $��Email��6A   $��0��6N   $��18(�6^   �� 54      -   5        $ txtEmail��54   "   $��1��64   $
��0 10q�6D   $��10q�6R   56      � 58       59      �� 5:      $��* �6/   �� 5;      $��2* �6/   .+�5>      �� $
 0 10q�6$   $
��0 10q�63   $	��Sex��6A   $��0��6L   $��18(�6\   �� 5?      -   5         ��Name$ comboSex��5?   #   $
��0 10q�65   $
��0 10q�6D   $��1��6R   .@�5@      �� .��6+   Male61   �� 5A      .��6+   Female63   5B      5C      � 5E       5F      �� 5G      $��* �6/   �� 5H      $��2* �6/   .+�5K      �� $
 0 10q�6$   $
��0 10q�63   $��Date Employed��6A   $��0��6V   $��18(�6f   (  "System.Windows.Controls.DatePicker  5L      -   5          Name$ DPdate��5L   %   $��1��65   $
��0 10q�6E   $
��0 10q�6T   5M      � 5O       5P      �� 5Q      $��* �6/   �� 5R      $��2* �6/   .+�5U      �� $
 0 10q�6$   $
��0 10q�63   $��Salary��6A   $��0��6O   $��18(�6_   �� 5V      -   5        $ 	txtSalary��5V   "   $��1��65   $
��0 10q�6E   $��10q�6S   5X      � 5Z       5[      �� 5\      $��* �6/   �� 5]      $��2* �6/   .+�5`      �� $
 0 10q�6$   $
��0 10q�63   $��
Department��6A   $��0��6S   $��18(�6c   �� 5a      -   5        $ txtDepartment��5a   #   $
��0 10q�6:   $
��0 10q�6I   $��1��6W   5c      5d      � 5f       5g      �� 5h      $��* �6/   �� 5i      $��2* �6/   .+�5l      �� $��0��6!   $��Capture��61   $��18(�6C   $
��Bold"�6Q   $��15q�6c   $��0 0 10 0q�6p   
����·�$��0q�6�   �� 5m      -	   5        	 ��Name$	 btnSave��5m   !   $��1��62   $��	Save Data��6B   $��18(�6V   $
��Bold"�6d   $��15q�6v   6�   5n      5p      5r      5t      5u      5v      