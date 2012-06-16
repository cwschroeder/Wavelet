#include<QApplication>
#include "Programm.h"
#include "Bild.h"
QString Programm::fileName="./Bild/Beispiel.bmp";
QString Programm::txtfileName="./Bild/Beispiel_black.txt";
//int **Blau,**Rot,**Grun,**Black;
int main(int argc,char**argv)
{
	QApplication app(argc,argv);
	Programm programm;
//	programm.setGeometry(0,0,1280,800);
	programm.showMaximized();
	return app.exec();	
}
