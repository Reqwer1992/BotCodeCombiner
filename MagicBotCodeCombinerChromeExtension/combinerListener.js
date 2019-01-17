let listenerLocation = document.getElementById('listenerLocation');
//listenerLocation.textContent = 'hello there';
var listenerLocationPort;

var hitPlayInIDE = function() {
	window.document.dispatchEvent(new CustomEvent('ExternalEditorToIDE', {
      'detail': {'status': 'play'}
    }));
};

var hitPlaySameConditionsInIDE = function() {
	$('button.replay').click();
};

var hitSubmitInIDE = function() {
	$('button.submit').click();
};

var updateCodeInIDE = function(code, callback) {
	window.document.dispatchEvent(new CustomEvent('ExternalEditorToIDE', {
      'detail': {'status': 'updateCode', 'code': code.replace(/\r\n/g, '\n').replace(/\r/g, '\n')}
    }));
	setTimeout(callback, 1000)
};

var launchListener =  function(){
	var listener = listenerLocationPort;

	function getCommand(){
		console.log("Waiting for code....");
		var postData = { 
			"action": "getCommand" 
		};

		$.post( listener, postData, function(response){
			if (response.Command == 0) {
				updateCodeInIDE(response.Code, null);
			} 
			else
			if (response.Command == 1) {
				updateCodeInIDE(response.Code, hitPlayInIDE);
			}
			else
			if (response.Command == 2) {
				updateCodeInIDE(response.Code, hitPlaySameConditionsInIDE);
			}
			else
			if (response.Command == 3) {
				updateCodeInIDE(response.Code, hitSubmitInIDE);
			}
		});
	}

	setInterval(getCommand, 2000);
};

chrome.storage.sync.get('combinerLocation', function(data) {
	listenerLocationPort = data.combinerLocation;
    //listenerLocation.textContent = listenerLocationPort;

    launchListener();
});

