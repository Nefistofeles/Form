   M S B A M L   `   `   `  ����E  AAdminPanel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AdminPanel
AdminPanel  5   	       AdminPanel.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AdminPanel     5   	     � Title$  
MainWindow��5	   	   $	��800��6   $
��1200��6)   ���	#FF0A0909$
��Bold"�6M    � WindowStartupLocation$ CenterScreen=�6_    � 
ResizeMode$ NoResize=�6�    � 	Resources 5         TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� Value �� 
TargetName �� Property �� 
TargetType F�Name �� Stretch ��Name��%�  &	        '�� �    '��     '�� a    �� 5   
   " ��6=   .R�5      �� $ Bd��5      #��z��5      
����  �#��z��5      $ 5��6E   ._�5      �� $ PART_ContentHost��6   5       5      P� 5      	 � {�
 .  . �5      �� # � ��63   $ Bd��6u    � ���� 5      # � ��63    � ��5      P� 5      	 � ��$

 Auto��6+   . �5      ��  � ��$	 100��61   5      P� 5      	 � ��$

 Auto��6,   . �5      ��  � ��$ 20��62   5      5      �� 5    
   " ��6   5#      �� 5$   
   " ��6   .�5%      ��  �@��CornerRadius$ 4��6-   69   5&      �� 5'   
   " ��6   .�5(      ��  � �� �#3737376+   �� 5)       � ��
 �����6+   �� 5*       �@J�SnapsToDevicePixels . 64   �� 5+       � ��$ 31��6'   �� 5,       � ��$	 156��6&   �� 5-       � ��$ 12(�6)   �� 5.       � �� 5/      �� 50      " ��6&   .R�51      �� $ 4��6!   #��z��62   ._�52      � .+�53   "   F� $ PathIcon��6'   $��20��69   $��15��6D   $
 Fill=�6P   ���#4C87B3$
��Left=�6n   $��5,0,0,0q�6�   a������!��ш�!�ހ�8���ހѸ� u�X4� u���x��C�X4� 6nѸ� 6n�8����ш�!��6�   �� 54   "   $ MyContentPresenter��63   #��z��6O   $��Center=�6s   $��Center=�6�   $��0,0,0,0q�6�   55      56       58      P� 59      	 �@J�IsMouseOver
 . . �5:   "   ��  � �� �#E594006?   �� 5;   "    � ��
 �����6?   �� 5<   "   $ PathIcon��6)    � ��
 �   �6O   5=      P� 5?      	 � ��
 . . �5@   "   ��  � ��
 � E��6?   �� 5A   "    � ��
 �����6?   5B      5D      5F      5G      5H      .��5I      � .+�5J   
   �� -   5        $��UsersConnection��5J      
�������
���   �$��3q�6S   $
��Left=�6g   $	��731��6�   $��	20,20,0,0q�6�   $	��Top=�6�   $
��1154��6�   ._�5K      � .+�5L      �� -   5        $��Nickname��5L   e   #��[  6   $��1q�6Q    �� TextWrapping$
 Wrap=�6u   $��477,225,416,453q�6�    �� TextAlignment$ Center=�6�   $��25(�6�   �� 5M      -   5        $��Password��5M   e   #��[  6   $��1q�6Q   $
 Wrap=�6u   $�� ��6�   $��477,322,416,356q�6�   $��25(�6�   $ Center=�6�   �� 5N      $
��Left=�6   $��477,200,0,0q�67   $
��Wrap=�6L   $��Nickname��6`   $	��Top=�6p   $��70��6�   $��20��6�   �� 5O      $
��Left=�6   $��477,302,0,0q�67   $
��Wrap=�6L   $��Password��6`   $	��Top=�6p   $��70��6�   $��20��6�   �� 5P      -   5        $��Button��5P      $
��Left=�6*   $��542,386,0,0q�6E   $	��Top=�6Z   $	��130��6r   6~   �� 5Q      -   5        $��ErrorUserTextBlock��5Q      $y�Hidden=�66   $
��Left=�6J   $��297,446,0,0q�6e   $
��Wrap=�6z   $��	TextBlock��6�   $	��Top=�6�   $��36��6�   $	��620��6�   $��20(�6�    �� TextAlignment$ Center=�6�   5R      5S      �� 5T   
   -   5        $��DatabaseTab��5T      $��20q�6(   
�������$y�Hidden=�6L   .@�5U      �� $��Create��6   
�������.��5W      � 
�������.+�5Y      �� $
��Left=�6    $��	24,25,0,0q�6;   $
��Wrap=�6N   $��Create Form��6b   $	��Top=�6u   $��30��6�   $	��199��6�   $��20(�6�   $ Center=�6�   $
��Bold"�6�   �� 5Z      $
��Left=�6    $��	24,71,0,0q�6;   $
��Wrap=�6N   $
��Name��6b   $	��Top=�6n   �� 5[      -   5        $��FormNameBoxCreate��5[      $
��Left=�67   $��23��6R   $��	24,92,0,0q�6^   $
 Wrap=�6q   $	��Top=�6�   $	��198��6�   �� 5\      $
��Left=�6    $��
24,130,0,0q�6;   $
��Wrap=�6O   $	��Tag��6c   $	��Top=�6n   �� 5]      -   5        $��FormTagBoxCreate��5]      $
��Left=�66   $��53��6Q   $��
24,151,0,0q�6]   $
 Wrap=�6q   $	��Top=�6�   $	��198��6�   �� 5^      $
��Left=�6    $��
23,220,0,0q�6;   $
��Wrap=�6O   $��IsActive��6c   $	��Top=�6s   �� 5_      $
��Left=�6    $��
24,275,0,0q�6;   $
��Wrap=�6O   $��Information��6c   $	��Top=�6v   �� 5`      -	   5        $��FormInformationBoxCreate��5`      $
��Left=�6>   $	��161��6Y   $��
24,296,0,0q�6f   $
 Wrap=�6z   $	��Top=�6�   $	��198��6�   �� 5a      -
   5        $��FormIsActiveCreate��5a      $��Active��69   $
��Left=�6J   $��
24,241,0,0q�6e   $	��Top=�6y   $��20��6�   $��83��6�   �� 5b      
���   �$��3q�61   $
��Left=�6E   $	��510��6`   $��	10,25,0,0q�6m   $	��Top=�6�   $	��227��6�   �� 5c      -   5        $��Create Form��5c      $
��Left=�63   $��
37,485,0,0q�6N   $	��Top=�6b   6z   �� 5e      $
��Left=�6    $��
267,25,0,0q�6;   $
��Wrap=�6O   $��Create Question��6c   $	��Top=�6z   $��30��6�   $	��199��6�   $��20(�6�   $ Center=�6�   $
��Bold"�6�   �� 5f      
���   �$��3q�61   $
��Left=�6E   $	��510��6`   $��
257,25,0,0q�6m   $	��Top=�6�   $	��227��6�   �� 5g      -   5        $��QuestionStringBoxCreate��5g      $
��Left=�6=   $	��169��6X   $��
267,92,0,0q�6e   $
 Wrap=�6y   $	��Top=�6�   $	��199��6�   �� 5h      $
��Left=�6    $��
267,71,0,0q�6;   $
��Wrap=�6O   $��Question String��6c   $	��Top=�6z   �� 5i      -   5        $��Create Question��5i      $
��Left=�67   $��290,485,0,0q�6R   $	��Top=�6g   6�   �� 5j      $
��Left=�6    $��282,399,0,0q�6;   $
��Wrap=�6P   $,��&You must select form from form list!!.��6d   $	��Top=�6�   $��58��6�   $	��199��6�   
����������	#FFDA2A2A$��15(�6�   �� 5l      $
��Left=�6    $��
527,25,0,0q�6;   $
��Wrap=�6O   $��Create Option��6c   $	��Top=�6x   $��30��6�   $	��199��6�   $��20(�6�   $ Center=�6�   $
��Bold"�6�   �� 5m      
���   �$��3q�61   $
��Left=�6E   $	��510��6`   $��
512,25,0,0q�6m   $	��Top=�6�   $	��235��6�   �� 5n      -   5        $��OptionBoxCreate��5n      $
��Left=�65   $	��169��6P   $��
527,92,0,0q�6]   $
 Wrap=�6q   $	��Top=�6�   $	��199��6�   �� 5o      $
��Left=�6    $��
533,71,0,0q�6;   $
��Wrap=�6O   $��Option��6c   $	��Top=�6q   �� 5p      $
��Left=�6    $��533,275,0,0q�6;   $
��Wrap=�6P   $��Point��6d   $	��Top=�6q   �� 5q      -   5        $��PointBoxCreate��5q      $
��Left=�64   $��23��6O   $��533,296,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $	��199��6�   �� 5r      -   5        $��Create Option��5r      $
��Left=�65   $��547,485,0,0q�6P   $	��Top=�6e   6}   �� 5s      $
��Left=�6    $��533,399,0,0q�6;   $
��Wrap=�6P   $4��.You must select Question from question list!!.��6d   $	��Top=�6�   $��58��6�   $	��199��6�   
����������	#FFDA2A2A$��15(�6�   �� 5v      -   5        $��ErrorBoxCreate��5v       $
��Left=�66   $��
10,615,0,0q�6Q   $
��Wrap=�6e   $�� ��6y   $	��Top=�6�   $��78��6�   $
��1128��6�   $��20(�6�   $
��Bold"�6�   �� 5x      $
��Left=�6    $��
762,33,0,0q�6;   $
��Wrap=�6O   $��Created Form List��6c   $	��Top=�6|   $��30��6�   $	��209��6�   $��20(�6�   $
��Bold"�6�   �� 5y      -   5        $��FormListCreate��5y   6   $��762,76,10,412q�6    �� View 5z      �� 5{      .P�5|   "   �� $
��Name��6W    �� DisplayMemberBinding 61   �� *Name+6g   �� 5}   "   $	��Tag��6V    61   �� *Tag+6e   �� 5~   "   $��IsActive��6[    61   �� *
IsActive+6o   �� 5   "   $��Information��6^    61   �� *Information+6u   5�      5�      �� 5�      $
��Left=�6    $��762,311,0,0q�6;   $
��Wrap=�6P   $��Created Question List��6d   $	��Top=�6�   $��30��6�   $	��235��6�   $��20(�6�   $
��Bold"�6�   �� 5�      -   5        $��QuestionListCreate��5�      $
��Left=�69   $	��189��6T   $��762,346,0,0q�6a   $	��Top=�6v   $	��386��6�    5�      �� 5�      .P�5�   "   �� $
��Name��6b    61   �� *Question_string+6r   5�      5�      �� 5�      -   5        $��
Find Forms��5�      $
��Left=�62   $��
982,40,0,0q�6M   $	��Top=�6a   6y   �� 5�      -   5        $��Find Questions��5�      $
��Left=�66   $��982,309,0,0q�6Q   $	��Top=�6f   6~   5�      5�      �� 5�      $��Delete��6   
�������.��5�      � 
�������.+�5�      �� $
��Left=�6    $��
10,204,0,0q�6;   $
��Wrap=�6O   $��Form Delete��6c   $	��Top=�6v   $��31��6�   $	��135��6�   
�������
���   �$��15(�6�   $ Center=�6�   �� 5�      
���   �$��3q�61   $
��Left=�6E   $	��335��6`   $��	0,195,0,0q�6m   $	��Top=�6�   $	��507��6�   �� 5�      -   5        $��FormListDelete��5�   7   $��10,245,671,188q�6    5�      �� 5�      .P�5�   "   �� $
��Name��6W    61   �� *Name+6g   �� 5�   "   $	��Tag��6V    61   �� *Tag+6e   �� 5�   "   $��IsActive��6[    61   �� *
IsActive+6o   �� 5�   "   $��Information��6^    61   �� *Information+6u   5�      5�      �� 5�      $
��Left=�6    $��
570,20,0,0q�6;   $
��Wrap=�6O   $��Question Delete��6c   $	��Top=�6z   $��30��6�   $	��217��6�   
�������
���   �$��15(�6�   $ Center=�6�   �� 5�      
���   �$��3q�61   $
��Left=�6E   $	��310��6`   $��
570,10,0,0q�6m   $	��Top=�6�   $	��568��6�   �� 5�      -   5        $��QuestionListDelete��5�      $
��Left=�69   $	��246��6T   $��
587,49,0,0q�6a   $	��Top=�6u   $	��537��6�    5�      �� 5�      .P�5�   "   �� $
��Name��6b    61   �� *Question_string+6r   5�      5�      �� 5�      $
��Left=�6    $��570,340,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $��30��6|   $	��217��6�   
�������
���   �$��15(�6�   $ Center=�6�   �� 6�   $�Question Option Delete��6�   �� 6  �� 6  6  �� 5�      
���   �$��3q�61   $
��Left=�6E   $	��325��6`   $��570,325,0,0q�6m   $	��Top=�6�   $	��568��6�   �� 5�      -   5        $��QuestionOptionListDelete��5�      $
��Left=�6?   $	��255��6Z   $��587,375,0,0q�6g   $	��Top=�6|   $	��537��6�    5�      �� 5�      .P�5�   "   �� $��Option_String��6`    61   �� *Option_string+6y   �� 5�   "   $��Point��6X    61   �� *Point+6i   5�      5�      �� 5�      -   5        $��Delete��5�      $
��Left=�6.   $��968,661,0,0q�6I   $	��Top=�6^   6v   �� 5�      -   5        $
��Find��5�      $
��Left=�6,   $��968,338,0,0q�6G   $	��Top=�6\   6t   �� 5�      -   5        $
��Find��5�      $
��Left=�6,   $��
968,17,0,0q�6G   $	��Top=�6[   6s   �� 5�      -   5        $
��Find��5�      $
��Left=�6,   $��321,204,0,0q�6G   $	��Top=�6\   6t   �� 5�      -   5        $��ControlBorder��5�      $y�Hidden=�62   
���   �$��3q�6Z   $��Right=�6n   $	��158��6�   $��0,535,756,0q�6�   $	��Top=�6�   $	��382��6�   ._�5�      � $��7,7,14,0q�6    � RowDefinitions 5�      �� 5�   "   $
��100* �60   �� 5�   "   $
��107* �60   .+�5�      �� $
��Left=�6(   $��	10,23,0,0q�6C   $
��Wrap=�6V   $	��Top=�6j   $��50��6�   $	��360��6�   
�������
���   �$��30(�6�   $ Center=�6�   $��2��6�   �� 6�   $�Are you sure?��6�   �� 6  �� 6  6%  �� 5�      -   5        $��NoButton��5�   %   $��No��65   $
��Left=�6B   $��	197,8,0,0q�6]   $	��Top=�6p   $	��156��6�   $��32��6�   $��1��6�   �� 5�      -   5        $��	YesButton��5�   %   $	��Yes��66   $
��Left=�6D   $��10,8,0,0q�6_   $	��Top=�6q   $	��156��6�   $��32��6�   $��1��6�   5�      5�      �� 5�      
���   �$��1q�61   $
��Left=�6E   $	��180��6`   $��	10,10,0,0q�6m   $	��Top=�6�   $	��220��6�   ._�5�      � $��-1,0,0,0q�6   .+�5�      �� $
��Left=�6(   $��84,0,0,0q�6C   $
��Wrap=�6U   $��Search��6i   $	��Top=�6w   �� 5�      -    5        $��Search��5�   %   $
��Left=�66   $��
26,126,0,0q�6Q   $	��Top=�6e   $	��156��6}   $��31��6�   $��10(�6�   6�   �� 5�      -!   5        $��DeleteSearchBox��5�   &   $
��Left=�6=   $��23��6X   $��	44,88,0,0q�6d   $
 Wrap=�6w   $	��Top=�6�   $	��120��6�   �� 5�      $
��Left=�6(   $��	10,33,0,0q�6C   $
��Wrap=�6V   $��Table��6j   $	��Top=�6w   �� 5�      -"   5         ��Name$ DeleteComboColumnBox��5�   '   $
��Left=�6E   $��
120,49,0,0q�6`   $	��Top=�6t   $��89��6�   �� 5�      $
��Left=�6(   $��
120,33,0,0q�6C   $
��Wrap=�6W   $��Column��6k   $	��Top=�6y   �� 5�      -#   5        $��DeleteTableData��5�   '   $
��Left=�6>   $��9,49,0,0q�6Y   $	��Top=�6k   $��90��6�   6�   �� 5�      -$   5        $��DeleteErrorSearchText��5�   (   $
��Left=�6E   $��
10,162,0,0q�6`   $
��Wrap=�6t   $	��Top=�6�   $	��200��6�   5�      5�      5�      5�      �� 5�      $��Update��6   
�������.��5�      � $��10,0,2,2q�6   
�������.+�5�      �� -%   5        $��FormListUpdate��5�   5   $��0,70,504,286q�6    5�      �� 5�      .P�5�   "   �� $
��Name��6W    61   �� *Name+6g   �� 5�   "   $	��Tag��6V    61   �� *Tag+6e   �� 5�   "   $��IsActive��6[    61   �� *
IsActive+6o   �� 5�   "   $��Information��6^    61   �� *Information+6u   5�      5�      �� 5�      -&   5        $
��Find��5�      $��	10,21,0,0q�6A   $
��Left=�6T   $	��Top=�6o   �� 5�      $
��Left=�6    $��
652,21,0,0q�6;   $
��Wrap=�6O   $
��Name��6c   $	��Top=�6o   $��2��6�   �� 5�      -'   5        $��FormNameBox��5�      $
��Left=�61   $��23��6L   $��
652,42,0,0q�6X   $
 Wrap=�6l   $	��Top=�6�   $	��198��6�   $��2��6�   �� 5�      $
��Left=�6    $��
652,89,0,0q�6;   $
��Wrap=�6O   $	��Tag��6c   $	��Top=�6n   $��2��6�   �� 5�      -(   5        $��
FormTagBox��5�      $
��Left=�60   $��53��6K   $��652,110,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��198��6�   $��2��6�   �� 5�      $
��Left=�6    $��652,183,0,0q�6;   $
��Wrap=�6P   $��IsActive��6d   $	��Top=�6t   $��2��6�   �� 5�      $
��Left=�6    $��652,233,0,0q�6;   $
��Wrap=�6P   $��Information��6d   $	��Top=�6w   $��2��6�   �� 5�      -)   5        $��FormInformationBox��5�      $
��Left=�68   $	��161��6S   $��652,254,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $	��198��6�   $��2��6�   �� 5�      -*   5        $��FormIsActive��5�      $��Active��63   $
��Left=�6D   $��652,204,0,0q�6_   $	��Top=�6t   $��20��6�   $��83��6�   $��2��6�   �� 5�      -+   5        $��QuestionListUpdate��5�      $
��Left=�69   $	��246��6T   $��	0,445,0,0q�6a   $	��Top=�6t   $	��312��6�   $��3��6�    5�      �� 5�      .P�5�   "   �� $
��Name��6b    61   �� *Question_string+6r   5�      5�      �� 5�      $
��Left=�6    $��
10,424,0,0q�6;   $
��Wrap=�6O   $��	Questions��6c   $	��Top=�6t   $��3��6�   �� 5�      -,   5        $��QuestionStringBox��5�      $
��Left=�67   $	��149��6R   $��315,466,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $	��155��6�   $��2��6�   �� 5�      $
��Left=�6    $��315,445,0,0q�6;   $
��Wrap=�6P   $��Question String��6d   $	��Top=�6{   $��2��6�   �� 5�      --   5        $��QuestionOptionListUpdate��5�      $
��Left=�6?   $	��246��6Z   $��485,445,0,0q�6g   $	��Top=�6|   $	��305��6�   $��2��6�    5�      �� 5�      .P�5�   "   �� $��Option_String��6`    61   �� *Option_string+6y   �� 5�   "   $��Point��6X    61   �� *Point+6i   5�      5�      �� 5      -.   5        $��	OptionBox��5      $
��Left=�6/   $	��146��6J   $��810,469,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��145��6�   $��2��6�   �� 5     $
��Left=�6    $��810,448,0,0q�6;   $
��Wrap=�6P   $��Option��6d   $	��Top=�6r   $��2��6�   �� 5     $
��Left=�6    $��810,630,0,0q�6;   $
��Wrap=�6P   $��Point��6d   $	��Top=�6q   $��2��6�   �� 5     -/   5        $��PointBox��5     $
��Left=�6.   $��23��6I   $��810,651,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   $��2��6�   �� 5     -0   5        $��Update��5     $
��Left=�6.   $��958,660,0,0q�6I   $	��Top=�6^   $��2��6�   �� 5     
���   �$��1q�61   $
��Left=�6E   $	��194��6`   $��
885,21,0,0q�6m   $	��Top=�6�   $	��220��6�   ._�5     � $��-1,0,0,0q�6   .+�5     �� $
��Left=�6(   $��84,0,0,0q�6C   $
��Wrap=�6U   $��Search��6i   $	��Top=�6w   �� 5     -1   5        $��Search��5  %   $
��Left=�66   $��
35,126,0,0q�6Q   $	��Top=�6e   $��10(�6}   6�   �� 5	     -2   5        $��UpdateSearchBox��5	  &   $
��Left=�6=   $��	10,88,0,0q�6X   $
 Wrap=�6k   $	��Top=�6   $	��199��6�   $��25��6�   �� 5
     $
��Left=�6(   $��	10,33,0,0q�6C   $
��Wrap=�6V   $��Table��6j   $	��Top=�6w   �� 5     -3   5        $ UpdateComboColumnBox��5  '   $
��Left=�6E   $��
120,49,0,0q�6`   $	��Top=�6t   $��89��6�   �� 5     $
��Left=�6(   $��
120,33,0,0q�6C   $
��Wrap=�6W   $��Column��6k   $	��Top=�6y   �� 5     -4   5        $��UpdateTableData��5  '   $
��Left=�6>   $��9,49,0,0q�6Y   $	��Top=�6k   $��90��6�   6�   �� 5     -5   5        $��UpdateErrorSearchText��5  (   $
��Left=�6E   $��	9,166,0,0q�6`   $
��Wrap=�6s   $	��Top=�6�   $	��200��6�   5     5     5     5     �� 5     $��
Statistics��6   
������.��5     � 
������.+�5     �� 
���   �$��4q�61   $
��Left=�6E   $	��455��6`   $��	10,10,0,0q�6m   $	��Top=�6�   $
��1128��6�   ._�5     � $��	-1,1,1,-1q�6   .+�5     �� -6   5        $��Search��5  %   $
��Left=�66   $��
10,406,0,0q�6Q   $	��Top=�6e   6}   �� 5     -7   5         ��Name$ StatisticFormList��5  =   $��10,10,731,62q�6'    5  "   �� 5  &   .P�5  *   �� $
��Name��6_    69   �� *Name+6_   �� 5  *   $	��Tag��6^    69   �� *Tag+6^   �� 5   *   $��IsActive��6c    69   �� *
IsActive+6c   �� 5!  *   $��Information��6f    69   �� *Information+6f   5#  '   5%     �� 5&     -8   5        $ StatisticResultList��5&  >   $��414,10,426,62q�6'    5'  "   �� 5(  &   .P�5)  *   �� $��Point��6`    69   �� *Point+6`   �� 5*  *   $��E_mail��6a    69   �� *E_mail+6a   5,  '   5.     �� 5/     $
��Left=�6(   $��
924,30,0,0q�6C   $
��Wrap=�6W   $��0 - 20��6k   $	��Top=�6y   $��30��6�   $��80��6�   $��20(�6�   $ Center=�6�   �� 50     $
��Left=�6(   $��
924,65,0,0q�6C   $
��Wrap=�6W   $��21 - 40��6k   $	��Top=�6z   $��30��6�   $��80��6�   $��20(�6�   $ Center=�6�   �� 51     $
��Left=�6(   $��924,100,0,0q�6C   $
��Wrap=�6X   $��41 - 60��6l   $	��Top=�6{   $��30��6�   $��80��6�   $��20(�6�   $ Center=�6�   �� 52     $
��Left=�6(   $��924,135,0,0q�6C   $
��Wrap=�6X   $��61 - 80��6l   $	��Top=�6{   $��30��6�   $��80��6�   $��20(�6�   $ Center=�6�   �� 53     $
��Left=�6(   $��924,170,0,0q�6C   $
��Wrap=�6X   $��81 - 100��6l   $	��Top=�6|   $��30��6�   $��80��6�   $��20(�6�   $ Center=�6�   �� 54     $
��Left=�6(   $��924,205,0,0q�6C   $
��Wrap=�6X   $
��>100��6l   $	��Top=�6{   $��30��6�   $��80��6�   $��20(�6�   $ Center=�6�   �� 55     -9   5        $��text020��55  (   $
��Left=�67   $��1024,30,0,0q�6R   $
��Wrap=�6g   $��0��6{   $	��Top=�6�   $��30��6�   $��80��6�   $��20(�6�   $ Center=�6�   �� 56     -:   5        $��text2140��56  (   $
��Left=�68   $��1024,65,0,0q�6S   $
��Wrap=�6h   $��0��6|   $	��Top=�6�   $��30��6�   $��80��6�   $��20(�6�   $ Center=�6�   �� 57     -;   5        $��text4160��57  (   $
��Left=�68   $��1024,100,0,0q�6S   $
��Wrap=�6i   $��0��6}   $	��Top=�6�   $��30��6�   $��80��6�   $��20(�6�   $ Center=�6�   �� 58     -<   5        $��text6180��58  (   $
��Left=�68   $��1024,135,0,0q�6S   $
��Wrap=�6i   $��0��6}   $	��Top=�6�   $��30��6�   $��80��6�   $��20(�6�   $ Center=�6�   �� 59     -=   5        $��	text81100��59  (   $
��Left=�69   $��1024,170,0,0q�6T   $
��Wrap=�6j   $��0��6~   $	��Top=�6�   $��30��6�   $��80��6�   $��20(�6�   $ Center=�6�   �� 5:     ->   5        $��text100must��5:  (   $
��Left=�6;   $��1024,205,0,0q�6V   $
��Wrap=�6l   $��0��6�   $	��Top=�6�   $��30��6�   $��80��6�   $��20(�6�   $ Center=�6�   5;     5<     5=     5>     5?     5@     5B     