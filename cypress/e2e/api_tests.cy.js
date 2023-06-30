describe("Books API suite", function () {
    it("GET - Read Books", function () {
        cy.request({
            method: 'GET',
            url: '/book',
            headers: {
                'api_key': 'your_api_key'
            }
        }).then(function (response) {
            expect(response.status).to.eq(200)
        })
    })
 })