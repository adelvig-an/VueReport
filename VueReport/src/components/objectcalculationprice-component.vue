<template>
    <div class="container">
        <div class="row align-items-end">
            <div class="col-3">
                <label class="form-lable">Валюта расчета</label>
                <select class="form-select">
                    <option value="1">Российский рубль (RUB)</option>
                    <option value="2">Доллар США (USD)</option>
                    <option value="3">Евро (EUR)</option>
                    <option value="7">Китайский юань (CNY)</option>
                </select>
            </div>
            <div class="col-2">
                <label class="form-lable">Дата оценки</label>
                <input type="date" class="form-control" />
            </div>
            <div class="col">
                <a class="btn btn-primary">Аналоги найдутся!</a>
            </div>
            <div class="col">
                <a class="btn btn-primary">Счетовод любитель!</a>
            </div>
        </div>
        


        <div class="row">
            <div class="col-2" v-for="analog in analogs" :key="analog.id">
                <div>
                    {{ analog.name }}
                    <input type="text" class="form-control" />
                </div>
                <a class="btn btn-primary" @click="deleteRow(analog.id)">Удалить</a>
            </div>
            <div class="col-2">
                <a class="btn btn-primary" @click="addRow">Добавить</a>
            </div>
        </div>


            <!-- Таблица расчета -->
            <div class="row" style="margin-top:14px">
                <div class="col-12">
                    Таблица расчета
                    <div>
                        <div style="display:flex">
                            <div style="width:200px">
                                <label style="font-size:12px">Параметр</label>
                            </div>
                            <div style="width:200px">
                                <label style="font-size:12px">Объект оценки</label>
                            </div>
                            <div style="width:200px">
                                <label style="font-size:12px">Аналог №1</label>
                            </div>
                            <div style="width:200px">
                                <label style="font-size:12px">Аналог №2</label>
                            </div>
                            <div style="width:200px">
                                <label style="font-size:12px">Аналог №3</label>
                            </div>
                        </div>

                        <div class="accordion" id="accordionPanelsStayOpenExample">
                            <div class="accordion-item">
                                <h2 class="accordion-header" id="panelsStayOpen-headingOne">
                                    <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseOne" aria-expanded="true" aria-controls="panelsStayOpen-collapseOne">
                                        Общая информация
                                    </button>
                                </h2>
                                <div id="panelsStayOpen-collapseOne" class="accordion-collapse collapse show" aria-labelledby="panelsStayOpen-headingOne">
                                    <div class="accordion-body">
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Источник информации</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="-" aria-label="-" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Телефон</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="-" aria-label="-" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Скриншоты страниц объявлений</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size: 12px; width: 150px; height: 150px" type="text" value="-" aria-label="-" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px; height:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size: 12px; width: 150px; height: 150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size: 12px; width: 150px; height: 150px" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="accordion-item">
                                <h2 class="accordion-header" id="panelsStayOpen-headingOne">
                                    <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseTwo" aria-expanded="true" aria-controls="panelsStayOpen-collapseTwo">
                                        Параметры сделки
                                    </button>
                                </h2>
                                <div id="panelsStayOpen-collapseTwo" class="accordion-collapse collapse show" aria-labelledby="panelsStayOpen-headingTwo">
                                    <div class="accordion-body">
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Цена предложения, руб.</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display: flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Стоимость объекта за кв.м., руб.</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Торг</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="-" aria-label="-" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Дата предложения</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="-" aria-label="-" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="date" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="date" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="date" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="accordion-item">
                                <h2 class="accordion-header" id="panelsStayOpen-headingThree">
                                    <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseThree" aria-expanded="true" aria-controls="panelsStayOpen-collapseThree">
                                        Параметры местоположения
                                    </button>
                                </h2>
                                <div id="panelsStayOpen-collapseThree" class="accordion-collapse collapse show" aria-labelledby="panelsStayOpen-headingThree">
                                    <div class="accordion-body">

                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Регион</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="Краснодарский край" aria-label="Краснодарский край" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Адрес</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="г. Краснодар, ул. Каляева, 200" aria-label="г. Краснодар, ул. Каляева, 200" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Метро/ж.д. станция</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="Водоканал" aria-label="Водоканал" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Время до метро/ж.д. станции</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="5 мин" aria-label="5 мин" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="accordion-item">
                                <h2 class="accordion-header" id="panelsStayOpen-headingFour">
                                    <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseFour" aria-expanded="true" aria-controls="panelsStayOpen-collapseFour">
                                        Параметры дома
                                    </button>
                                </h2>
                                <div id="panelsStayOpen-collapseFour" class="accordion-collapse collapse show" aria-labelledby="panelsStayOpen-headingFour">
                                    <div class="accordion-body">

                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Материал стен</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="Кирпич" aria-label="Кирпич" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Этаж расположения объекта</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="6" aria-label="6" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Этажность дома</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="25" aria-label="25" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Благоустройство дома</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="-" aria-label="-" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Состояние дома</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="Хорошее" aria-label="Хорошее" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Инжинерные системы</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="Электроснабжение, канализация, ХВС и ГВС" aria-label="Электроснабжение, канализация, ХВС и ГВС" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="accordion" id="accordionPanelsStayOpenExample">
                            <div class="accordion-item">
                                <h2 class="accordion-header" id="panelsStayOpen-headingFive">
                                    <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseFive" aria-expanded="true" aria-controls="panelsStayOpen-collapseFive">
                                        Параметры объекта оценки
                                    </button>
                                </h2>
                                <div id="panelsStayOpen-collapseFive" class="accordion-collapse collapse show" aria-labelledby="panelsStayOpen-headingFive">
                                    <div class="accordion-body">

                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Количество комнат</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="3" aria-label="3" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Общая площадь, кв.м.</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="73,5" aria-label="73,5" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Жилая площадь, кв.м.</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="54" aria-label="54" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Площадь кухни</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="10" aria-label="10" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Наличие балкона/лоджии</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="Лоджия" aria-label="Лоджия" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>

                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Вид из окна</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="Во двор и на улицу" aria-label="Во двор и на улицу" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px">
                                                    <option value="1">На улицу</option>
                                                    <option value="2">Во двор</option>
                                                    <option value="3">Во двор и на улицу</option>
                                                </select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px">
                                                    <option value="1">На улицу</option>
                                                    <option value="2">Во двор</option>
                                                    <option value="3">Во двор и на улицу</option>
                                                </select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px">
                                                    <option value="1">На улицу</option>
                                                    <option value="2">Во двор</option>
                                                    <option value="3">Во двор и на улицу</option>
                                                </select>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>

                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Высота потолков, м.</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="2.7" aria-label="2.7" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>

                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Санузел</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="Раздельный" aria-label="Раздельный" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>

                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Качество отделки</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="Хорошее" aria-label="Хорошее" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>

                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Наличие мебели</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="-" aria-label="-" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                            <div style="width:200px">
                                                <select class="form-select" style="font-size:12px; width:150px"></select>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <a href="#" style="font-size:12px">Изменить описание</a>
                                            </div>
                                            <div style="width:200px">
                                                <label style="font-size:12px">Корректировка, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                            <div style="width:200px">
                                                <input type="text" class="form-control" style="font-size:12px; width:150px" />
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="accordion" id="accordionPanelsStayOpenExample2">
                            <div class="accordion-item">
                                <h2 class="accordion-header" id="panelsStayOpen-1">
                                </h2>
                                <div id="panelsStayOpen-1" class="accordion-collapse collapse show" aria-labelledby="panelsStayOpen-1">
                                    <div class="accordion-body">

                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Итоговое значение относительных корректировок, %</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="-" aria-label="-" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Скорректированная цена объекта аналога (руб./кв.м.)</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="-" aria-label="-" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Валовая коррекция</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="-" aria-label="-" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Весовой коэффициент</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="-" aria-label="-" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                        </div>
                                        <div style="display:flex; margin-top: 3.5px; margin-bottom: 3.5px">
                                            <div style="width:200px">
                                                <label style="font-size:12px">Взвешенная стоимость за 1 кв.м., руб.</label>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="-" aria-label="-" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                            <div style="width:200px">
                                                <input class="form-control" style="font-size:12px; width:150px" type="text" value="0" aria-label="0" disabled readonly>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>





    </div>
</template>

<script>
    export default {
        name: 'objectcalculationprice-component',
        data() {
            return {
                index: 1,
                analogs: []
            }
        },
        methods: {
            addRow()
            {
                this.analogs.push({
                    id: this.index - 1,
                    name: 'Аналог №' + this.index,
                });
                this.index++;
            },
            deleteRow(index) {
                //this.analogs.splice(index, 1);
                //this.analogs = 
                this.analogs = this.analogs.filter((n, i) => !this.analogs.includes(i));
            }
        }
    }
</script>




<!--<div class="row" style="margin-top:14px">
            <div class="col-lg-12">
                <div class="table-responsive">
                    <table class="table table-bordered table-striped table-hover">
                        <thead>
                            <tr>
                                <th class="col-lg-2">Характеристики объекта</th>
                                <th class="col-lg-2">Объект оценки</th>
                                <th>Аналог №1</th>
                                <th>Аналог №2</th>
                                <th>Аналог №3</th>
                                <th>Аналог №4</th>
                                <th class="col-lg-2"><a class="btn btn-success">Добавить аналог</a></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th scope="row">
                                    Скриншот
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Телефон
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Источники информации
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row" colspan="6">
                                    Параметры сделки
                                </th>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Цена предложения, руб.
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Площадь объекта
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Стоимость объекта за кв. м
                                </th>
                                <td>2</td>
                                <td>3</td>
                                <td>4</td>
                                <td>5</td>
                                <td>6</td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Торг
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на торг
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Права на недвижимость
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на передаваемые права на недвижимость
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Условия финансирования
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на условия финансирования
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Условия продажи
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на условия продажи
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Дата предложения
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="date" /></td>
                                <td><input class="form-control" type="date" /></td>
                                <td><input class="form-control" type="date" /></td>
                                <td><input class="form-control" type="date" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на дату предложения
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row" colspan="6">
                                    Параметры местоположения
                                </th>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Местоположение
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на местоположение
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Метро/ж.д. станция/остановка общественного транспорта
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Время до метро/ж.д. станции/остановки общественного транспорта
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на метро/ж.д. станции/остановки общественного транспорта
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Тип дома
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на параметры дома
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Этаж расположения объекта
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Этажность дома
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на этаж и этажность
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Благоустройство дома
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на благоустройство дома
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Состояние дома
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на состояние дома
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Инженерные системы
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на инженерные системы
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row" colspan="6">
                                    Параметры объекта оценки
                                </th>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Количество комнат
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на количество комнат
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Площадь объекта
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на площадь объекта
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Жилая площадь
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на жилую площадь
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Площадь кухни
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на площадь кухни
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Наличие балкона/лоджии
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на наличие балкона/лоджии
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Вид из окна
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на вид из окон
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Высота потолков, м
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на высоту потолков
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Санузел
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на санузел
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Качество отделки
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на состояние отделки объекта
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Наличие мебели
                                </th>
                                <td>2</td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                                <td><select class="form-select"></select></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Корректировка на наличие мебели
                                </th>
                                <td>2</td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                                <td><input class="form-control" type="text" /></td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Итоговое значение относительных корректировок, %
                                </th>
                                <td>2</td>
                                <td>3</td>
                                <td>4</td>
                                <td>5</td>
                                <td>6</td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Скорректированная цена объекта-аналога (руб./кв.м.)
                                </th>
                                <td>2</td>
                                <td>3</td>
                                <td>4</td>
                                <td>5</td>
                                <td>6</td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Валовая коррекция
                                </th>
                                <td>2</td>
                                <td>3</td>
                                <td>4</td>
                                <td>5</td>
                                <td>6</td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Весовой коэффициент
                                </th>
                                <td>2</td>
                                <td>3</td>
                                <td>4</td>
                                <td>5</td>
                                <td>6</td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Взвешенная стоимость за 1 кв.м
                                </th>
                                <td>2</td>
                                <td>3</td>
                                <td>4</td>
                                <td>5</td>
                                <td>6</td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Средняя стоимость 1 кв.м, руб.
                                </th>
                                <td colspan="5">2</td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    Рыночная стоимость объекта оценки, рассчитанная методом сравнения продаж, округленно, руб.
                                </th>
                                <td colspan="5">2</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class="col-2" hidden>
                <a class="btn btn-success">Добавить аналог</a>
            </div>
        </div>-->
