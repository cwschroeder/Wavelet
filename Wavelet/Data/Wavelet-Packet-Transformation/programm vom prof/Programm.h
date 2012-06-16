#ifndef PROGRAMM_H
#define PROGRAMM_H
#include<QMainWindow>
#include<QtGui>
class Bild;
class Programm:public QMainWindow
{
	Q_OBJECT
	public:
		Programm();
        QImage *image;
        static QString fileName;
        static QString txtfileName;        
//        static **Blau,**Rot,**Grun,**Black;
        Bild *Hintergrund;
        signals:
	private:
            
  	private slots:
    void toPixel();
    bool toImage();
    bool laden(); 
    void ladentoPixel();        
};
#endif

