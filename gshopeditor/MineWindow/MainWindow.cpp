// MineWindow.cpp: главный файл проекта.

#include "stdafx.h"
#include "MainWindow.h"


[STAThreadAttribute]
int main(array<System::String ^> ^args)
{
	// Включение визуальных эффектов Windows XP до создания каких-либо элементов управления
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false); 

	// Создание главного окна и его запуск
	Application::Run(gcnew MainWindow());
	return 0;
}
