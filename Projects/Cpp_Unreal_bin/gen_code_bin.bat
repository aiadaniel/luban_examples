set WORKSPACE=..\..

set GEN_CLIENT=%WORKSPACE%\Tools\Luban.ClientServer\Luban.ClientServer.exe
set CONF_ROOT=%WORKSPACE%\DesignerConfigs

%GEN_CLIENT% -j cfg --^
 -d %CONF_ROOT%\Defines\__root__.xml ^
 --input_data_dir %CONF_ROOT%\Datas ^
 --output_code_dir Source/Cpp_Unreal/Private/Gen ^
 --output_data_dir ..\GenerateDatas\bytes ^
 --gen_types code_cpp_bin,data_bin ^
 -s all 

pause