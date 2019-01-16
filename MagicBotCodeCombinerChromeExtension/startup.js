chrome.runtime.onInstalled.addListener(function() {
	defaultLocation = 'http://localhost:60581/';
    chrome.storage.sync.set({combinerLocation: defaultLocation}, function() {
      console.log("MagicBotCombiner location is set to "+defaultLocation);
    });
	
	chrome.declarativeContent.onPageChanged.removeRules(undefined, function() {
      chrome.declarativeContent.onPageChanged.addRules([{
        conditions: [new chrome.declarativeContent.PageStateMatcher({
          pageUrl: {hostEquals: 'www.codingame.com'},
        })
        ],
            actions: [new chrome.declarativeContent.ShowPageAction()]
      }]);
    });
  });