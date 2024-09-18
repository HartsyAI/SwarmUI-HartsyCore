document.addEventListener("DOMContentLoaded", function () {
    const html = `
        <!-- HartsyTab -->
        <li class="nav-item" role="presentation">
            <a class="nav-link translate" data-bs-toggle="tab" href="#hartsytab" id="hartsytabbutton" aria-selected="false" tabindex="-1" role="tab">Hartsy</a>
        </li>
        <div class="tab-pane" id="hartsytab" role="tabpanel">
            <ul class="nav nav-tabs" id="hartsytablist">
            </ul>
        </div>
    `;
    let tempDiv = document.createElement('div');
    tempDiv.innerHTML = html;
    let newTab = tempDiv.querySelector('li');
    let newTabContent = tempDiv.querySelector('.tab-pane');
    // Inject the new tab into the tab list
    let tabList = document.getElementById('toptablist');
    tabList.appendChild(newTab);
    // Inject the new tab content into the tab content container
    let tabContentContainer = document.querySelector('.tab-content');
    tabContentContainer.appendChild(newTabContent);
});