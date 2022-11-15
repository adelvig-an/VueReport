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
        <div class="row" style="margin-top:14px">
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
        </div>
    </div>
</template>