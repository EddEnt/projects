﻿//Importing 2 Electron modules. Electron follows typical JavaScript conventions here
//App - Controls application event lifecycle - camelCase style, modules that are not instandiable
//BrowserWindow - Creates and manages app windows - PascalCase style, modules that are instaniable class constructors
const { app, BrowserWindow } = require('electron/main')

//createWindow function loads the web page into a new BrowserWindow instance
const createWindow = () => {
  const win = new BrowserWindow({
    width: 800,
    height: 600
  })

  win.loadFile('index.html')
}

//Calling the created function when the app is ready
app.whenReady().then(() => {
  createWindow()

    //Many of Electron's core modules are Node.js event emitters that adhere to Node's asynchronous event-driven architecture.
    //The { app } module is one of these emitters
    //You typically listen to Node.js events by using an emitter's .on function.
    //However, Electron exposes app.whenReady() as a helper specifically for the ready event to avoid subtle pitfalls with directly listening to that event in particular
    //More details: https://github.com/electron/electron/pull/21972
    //Running the 'start' script command in package.json should open a window with the web page

    //Windows cannot be created before the ready event
    app.on('activate', () => {
        if (BrowserWindow.getAllWindows().length === 0) {
            createWindow()
        }
    })
})

//Quitting the application when all windows are closed. On Windows and Linux, this is largely the case
//On Mac, apps generally continue to run when there are no open windows
app.on('window-all-closed', () => {
    if (process.platform !== 'darwin') {
        app.quit()
    }
})
