import { BlogTemplatePage } from './app.po';

describe('Blog App', function() {
  let page: BlogTemplatePage;

  beforeEach(() => {
    page = new BlogTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
