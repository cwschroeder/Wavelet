/****************************************************************************
** Meta object code from reading C++ file 'Programm.h'
**
** Created: Sun 29. Jan 11:41:01 2012
**      by: The Qt Meta Object Compiler version 59 (Qt 4.3.2)
**
** WARNING! All changes made in this file will be lost!
*****************************************************************************/

#include "../Programm.h"
#if !defined(Q_MOC_OUTPUT_REVISION)
#error "The header file 'Programm.h' doesn't include <QObject>."
#elif Q_MOC_OUTPUT_REVISION != 59
#error "This file was generated using the moc from 4.3.2. It"
#error "cannot be used with the include files from this version of Qt."
#error "(The moc has changed too much.)"
#endif

static const uint qt_meta_data_Programm[] = {

 // content:
       1,       // revision
       0,       // classname
       0,    0, // classinfo
       4,   10, // methods
       0,    0, // properties
       0,    0, // enums/sets

 // slots: signature, parameters, type, tag, flags
      10,    9,    9,    9, 0x08,
      25,    9,   20,    9, 0x08,
      35,    9,   20,    9, 0x08,
      43,    9,    9,    9, 0x08,

       0        // eod
};

static const char qt_meta_stringdata_Programm[] = {
    "Programm\0\0toPixel()\0bool\0toImage()\0"
    "laden()\0ladentoPixel()\0"
};

const QMetaObject Programm::staticMetaObject = {
    { &QMainWindow::staticMetaObject, qt_meta_stringdata_Programm,
      qt_meta_data_Programm, 0 }
};

const QMetaObject *Programm::metaObject() const
{
    return &staticMetaObject;
}

void *Programm::qt_metacast(const char *_clname)
{
    if (!_clname) return 0;
    if (!strcmp(_clname, qt_meta_stringdata_Programm))
	return static_cast<void*>(const_cast< Programm*>(this));
    return QMainWindow::qt_metacast(_clname);
}

int Programm::qt_metacall(QMetaObject::Call _c, int _id, void **_a)
{
    _id = QMainWindow::qt_metacall(_c, _id, _a);
    if (_id < 0)
        return _id;
    if (_c == QMetaObject::InvokeMetaMethod) {
        switch (_id) {
        case 0: toPixel(); break;
        case 1: { bool _r = toImage();
            if (_a[0]) *reinterpret_cast< bool*>(_a[0]) = _r; }  break;
        case 2: { bool _r = laden();
            if (_a[0]) *reinterpret_cast< bool*>(_a[0]) = _r; }  break;
        case 3: ladentoPixel(); break;
        }
        _id -= 4;
    }
    return _id;
}
