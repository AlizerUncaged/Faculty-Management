   M S B A M L   `   `   `  ????E  AGroup3Proj, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Group3Proj
Group3Proj  5   	   '    !Group3Proj.AttendanceRecordWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Group3Proj     5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          ? Icon$  
itlogo.png??5   	    ? 
ResizeMode$ NoResize=?5
   	    ? Title$  ??5   	   $	??600??6   $	??800??6    ? 	Resources 5      $   Group3Proj.dbAttendanceDataSet   dbAttendanceDataSet  attendanceViewSource ?? Source ?? Source??%[   &	        &	      7     5   
   6$   ?? 5   
    6<   ?? *
attendance+8   5      .??5      ?  ? DataContext# [ 6   ??5   
   ?? 5       ?? EndPoint$ 0.5,1&?6"    ?? 
StartPoint$ 0.5,0&?63   .??5      ? 	 ? Color$	 Black??6   ? 5      $	 	#FF08D57F??6   
 ? Offset$
 1Q?61   5      .+?5   
   ?? $??2q?6   ???	#FF08D57F6%   ?? 5   
   $?? Attendance Records??6   $
??Left=?6.   $??
164,80,0,0q?6I   $	??Top=?6]   $??63??6u   $	??463??6?   $??Arial)?6?   $??48(?6?   ???	#FFFDA1A16?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ attendancetb??5         CanUserAddRows .  $
??Left=?6@   $	??306??6[   $??
90,191,0,0q?6h   $	??Top=?6|   $	??583??6?   ??6?   ?? ?? 5   
   -   5         ??Name$ GenerateButton??5      $??Center=?6)   $
??Auto??6F   ???	#FF50B433$??27,25,707,500q?6k   ???	#FF50B433+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 25??6?   $??60??6?   .??5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowBack=?6*   $??25??6;   $??25??6F   5      5      5      5       