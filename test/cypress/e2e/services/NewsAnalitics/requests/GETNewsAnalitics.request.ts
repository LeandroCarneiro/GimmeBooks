/// <reference types="cypress"/>

function getNewsAnalitics(){
    return cy.request({
        method: 'GET',
        url: `NewsAnalitics`,
        headers: { 'Accept-Language': 'en-us', },
        failOnStatusCode: false,
    });
}

export { getNewsAnalitics };