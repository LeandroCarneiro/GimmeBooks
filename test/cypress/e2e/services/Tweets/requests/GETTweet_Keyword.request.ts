/// <reference types="cypress"/>

function getTweetsKeyword(request: string){
    return cy.request({
        method: 'GET',
        url: `Tweet?keywords=${request}`,
        headers: { 'Accept-Language': 'en-us', },
        failOnStatusCode: false,
    });
}

export { getTweetsKeyword };