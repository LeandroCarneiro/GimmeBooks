const { defineConfig } = require('cypress')

module.exports = defineConfig({
  e2e: {
    setupNodeEvents(on, config) {},
    baseUrl: 'https://localhost:44331/gimmeBooks/api',
    supportFile: false
  },
})
