// MineWindow.cpp: ������� ���� �������.

#include "stdafx.h"
#include "MainWindow.h"


[STAThreadAttribute]
int main(array<System::String ^> ^args)
{
	// ��������� ���������� �������� Windows XP �� �������� �����-���� ��������� ����������
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false); 

	// �������� �������� ���� � ��� ������
	Application::Run(gcnew MainWindow());
	return 0;
}
