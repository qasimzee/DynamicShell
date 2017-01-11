module.exports = {
  stripPrefix: 'src/',
  staticFileGlobs: [
    
  ],
  runtimeCaching: [{
    urlPattern: '/',
    handler: "cacheFirst"
  }],
  swFilePath: 'service-worker.js'
};