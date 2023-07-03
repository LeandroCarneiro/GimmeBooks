const { defineConfig } = require('cypress')

module.exports = defineConfig({
  e2e: {
    setupNodeEvents(on, config) {},
    baseUrl: 'https://localhost:5001/api/',
    supportFile: false,
    video: false,
    responseTimeout: 600000  
  },
})