#include<QtGui>
#include<QPaintDevice>
#include "Bild.h"
#include "Programm.h"
void Bild::paintEvent(QPaintEvent *)
 {
	 QPainter painter(this);
 //    image->scaled( const QSize & size,Qt::KeepAspectRatio, Qt::TransformationMode transformMode = Qt::FastTransformation )
   	painter.drawImage(QPoint(0, 0),*image);

 }
Bild::Bild()
{	
   image=new QImage(Programm::fileName);
	if(image->isNull())
	{
	QMessageBox Warnung;
	Warnung.warning(this,"Achtung",Programm::fileName+" konnte nicht gefunden werden!");
    }
//	image=new QImage(1272,800,QImage::Format_ARGB32);
//	image->fill(qRgb(5, 0, 55));


}
void Bild::drawBild()
{
//     image->fill(qRgb(5, 0, 55));

}
