   M S B A M L   `   `   `  ����@  <MyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MyApp.ViewsMyApp.Views  5   	       MyApp.Views.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MyApp.Views     5   	     � Title$  Авторизация��5   	   $	��310��6   $	��335��6*   .��5	      � ���	#FFF1E1EF$��0,0,0,-6q�6"    � ColumnDefinitions 5
   
   �� 5      $
��317* �6   �� 5      $	��15* �6   .+�5   
   �� $��Center=�6   $
��Left=�60   $	��264��6K   $��2��6X   $��6,0,0,0q�5      .+�5      ��  �� TextAlignment$ Center=�6   $��25(�5      $
��Bold"�6&   $	��303��5      $��
Constantia)�6$   $��59��6<   $��Center=�6H   �� 6f   $�Добро ��6j   �� 6z   �� 6�   $�пожаловать��6�   6�   �� 5      $��0,5,0,0q�6   $��Center=�6)   $��14(�6F   $��Вход��6T   $��
Constantia)�6`   �� 5      $��0,0,0,5q�6   $	��207��6)   $��
Constantia)�65   $��
Логин��5      �� 5      $	��211��6U   $��
Constantia)�5      ��5      �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5      $��Пароль��6   $��0,10,0,5q�6&   $	��210��68   $��
Constantia)�6D   G� 5      -   5         G�Name$ PasswordBox��5      $��
Constantia)�6/   $	��212��6G   � 5      $	��319��6   $��0,5,0,0q�6    � RowDefinitions 5      �� 5      .+�5!      �� $��
Войти��6   $��	64,10,0,0q�5#      $
��Left=�6,   $��85��6G   ���	#FFD9B4D5$��
Constantia)�5$   0   ��5!   )   �� *LoginCommand+��5"      ��  �� ElementName$ PasswordBox����5$   H   Z� �� 5%      $��Регистрация��6   $��
168,10,0,0q�6S   $
��Left=�5&      $��85��64   ���	#FFD9B4D5$��
Constantia)�5'      ��5%   /   �� *RegisterCommand+��5'   1   Z� 5(      �� 5)      $��56��6   $��/Images/cat1.jpg��6    $
��Fill=�6:   $��66��6I   $��Bottom=�6T   $��Center=�6o   $��0,10,0,5q�6�   5*      5+      5,      