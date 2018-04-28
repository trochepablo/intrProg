function contarMinas(){
    ContarMinasAlrededor();
} 

function ContarMinasAlrededor(){
/* 
proposito: denota cantidad de minas que hay en las celdas alrededor de la actual.
orecondicion: -
*/
    cantidadMinas := 0;
    foreach dir in [minDir()..maxDir()]{
        cantidadMinas := contarMinasDiagonal(dir);
    }
    return (cantidadMinas);
}

function contarMinasDiagonal (dir){
/*
proposito: denota cantidad de bolitas que hay en las celdas alrededor de la actual
precondicion: -
*/
    Mover(dir);
    contarMinas := 0;
    if (hayMina()){
        contarminas := nroBolitas(Rojo);
    }
    if (hayMina()){
        Mover(siguente(dir));
        contarminas := nroBolitas(Rojo);
    }
    RetornarOrigen(opuesto(siguiente(dir), opuesto(dir)));
    return (contarminas)
}

function hayMina(){
/*
porposito: detonar verdadero si hay una mina en la celda actual
precondicion: -
 */
    return (hayBolitas(Rojo))
}

procedure RetornarOrigen(dirHorizontal, dirVertical){
/*
proposito: mueve el cabezal hacia la celda origen
precondicion: el cabezal no debe estar en los extremos dirHorizontal y dirVertical
 */
    Mover(dirHorizontal);
    Mover(dirVertical);
}

//poner pista
procedure PonerPista(){
/*
proposito: pone en la celda actual una pista por cantidad de minas que hay en las celdas alrededor
precondicion: -
*/
    repeat(ContarMinasAlrededor()){
        Poner(Azul);
    }
}