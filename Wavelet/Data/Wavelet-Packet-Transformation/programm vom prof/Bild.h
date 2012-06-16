#ifndef BILD_H
#define BILD_H
#include<QtGui>
class Programm;
class Bild:public QWidget
{
      Q_OBJECT
      public:
            QImage *image;
      private:
      QPrinter *printer;
      
      public:
      
      Bild();
      void paintEvent(QPaintEvent *);
      void drawBild();
      
	
};
#endif

