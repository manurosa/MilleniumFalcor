var model = require('./model.js')

model
  .get(['person[0..1]'])
  .then(function (response) {
    document.write(response.json)
  }, function (err) {
    if (err) {
      console.log(err)
    }
  })
