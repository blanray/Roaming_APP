
import tkinter as tk
from tkinter import ttk

class A2P_Uruguay(ttk.Frame):
        
        def __init__(self, *args, **kwargs):
            super().__init__(*args, **kwargs)
            
            self.name_entry = ttk.Entry(self)
            self.name_entry.pack()
            
  

class Roaming(ttk.Frame):
        
        def __init__(self, *args, **kwargs):
            super().__init__(*args, **kwargs)
            
            self.label = ttk.Label(self)
            self.label["text"] = ("En contruccion")
            self.label.pack()
            
            self.web_button = ttk.Button(self, text="Mas infb")
            self.web_button.pack(pady=10)

class LDI(ttk.Frame):
        
        def __init__(self, *args, **kwargs):
            super().__init__(*args, **kwargs)
            
            self.label = ttk.Label(self)
            self.label["text"] = ("En construccion")
            self.label.pack()
            

class Application(ttk.Frame):
        
        def __init__(self, main_window):
            super().__init__(main_window)
            main_window.title("Mi Tablero")
                        
            self.notebook = ttk.Notebook(self)
                        
            self.A2P_frame = A2P_Uruguay(self.notebook)
            self.notebook.add(self.A2P_frame, text="A2P-Uruguay", padding=10)
                       
            self.Roaming_frame = Roaming(self.notebook)
            self.notebook.add(self.Roaming_frame, text="Roaming", padding=10)
            
            self.LDI_frame = Roaming(self.notebook)
            self.notebook.add(self.LDI_frame, text="LDI", padding=10)
                                
            self.notebook.pack(fill="both", expand = "true")
            self.pack(fill="both", expand = 1)
            
            
main_window = tk.Tk()
app = Application(main_window)

w, h = main_window.winfo_screenwidth(), main_window.winfo_screenheight()
main_window.geometry("%dx%d+0+0" % (w, h))

app.mainloop()