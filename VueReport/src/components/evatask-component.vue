<template>
    <div class="container">
        <div class="row mb-2">
            <div class="col">
                <h5>
                    Задание на оценку
                </h5>
            </div>
            <div class="col-lg-1 col-md-2">
                <label class="form-label">
                    Оценщик
                </label>
            </div>
            <div class="col-md-4">
                <select class="form-select" style="width:100%">
                    <option value="1">Крещенко Олег Александрович</option>
                    <option value="2">Еговцев Вячеслав Алексеевич</option>
                    <option value="3">Авдеев Александр Владимирович</option>
                </select>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <h6>Объект оценки</h6>
            </div>
            <div class="col-md-2">
                <a class="btn btn-success" 
                   style="float:right" 
                   data-bs-toggle="modal" 
                   data-bs-target="#exampleModal">
                Добавить объект
                </a>
            </div>

            <!-- Модальное окно -->
            <div class="modal fade" 
                 id="exampleModal" 
                 tabindex="-1" 
                 data-bs-keyboard="false" 
                 data-bs-backdrop="static" 
                 aria-labelledby="exampleModalLabel" 
                 aria-hidden="true">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-body">

                            <!-- Тип недвижимости -->
                            <div class="row g-2" role="group">
                                <div class="col-md-auto">
                                    <input type="radio" value="ResidentialRealEstate" name="radioRealEstate" v-model="isRealEstate" id="ResidentialRealEstate"
                                           class="btn-check" />
                                    <label for="ResidentialRealEstate" style="margin-right:7px" class="btn btn-outline-primary">Жилая недвижимость</label>
                                    <input type="radio" value="NonResidentialRealEstate" name="radioRealEstate" v-model="isRealEstate" id="NonResidentialRealEstate"
                                           class="btn-check" />
                                    <label for="NonResidentialRealEstate" style="margin-right:7px" class="btn btn-outline-primary">Нежилая недвижимость</label>
                                    <input type="radio" value="LandPlot" name="radioRealEstate" v-model="isRealEstate" id="LandPlot"
                                           class="btn-check" />
                                    <label for="LandPlot" style="margin-right:7px" class="btn btn-outline-primary">Земельный участок</label>
                                </div>
                            </div>

                            <!-- Тип жилой недвижимости -->
                            <div class="row g-2" style="margin-top: 4px" role="group">
                                <div class="col-md-auto" v-if="isRealEstate === 'ResidentialRealEstate'">
                                    <input type="radio" value="ResidentialPremises" v-model="isResidentialPremises" name="radioResidentialRealEstate" id="ResidentialPremises"
                                           class="btn-check" />
                                    <label for="ResidentialPremises" style="margin-right:7px" class="btn btn-outline-primary">Жилое помещение</label>
                                    <input type="radio" value="ResidentialBuilding" v-model="isResidentialPremises" name="radioResidentialRealEstate" id="ResidentialBuilding"
                                           class="btn-check" />
                                    <label for="ResidentialBuilding" style="margin-right:7px" class="btn btn-outline-primary">Жилой дом</label>
                                </div>
                                <div class="col-md-auto" v-else-if="isRealEstate === 'NonResidentialRealEstate'">Типы нежилой недвижимости</div>
                                <div class="col-md-auto" v-else-if="isRealEstate === 'LandPlot'">Типы земельных участков</div>
                                <div class="col-md-auto" v-else></div>
                            </div>

                            <!-- Тип жилых помещений -->
                            <div class="row g-2" style="margin-top: 4px" role="group">
                                <div class="col-md-auto" v-if="isResidentialPremises === 'ResidentialPremises'">
                                    <input type="radio" value="Flat" name="radioResidentialPremises" id="Flat"
                                           class="btn-check" />
                                    <label for="Flat" style="margin-right:7px" class="btn btn-outline-primary">Квартира</label>
                                    <input type="radio" value="Apartment" name="radioResidentialPremises" id="Apartment"
                                           class="btn-check" />
                                    <label for="Apartment" style="margin-right:7px" class="btn btn-outline-primary">Апартаменты</label>
                                    <input type="radio" value="PartFlat" name="radioResidentialPremises" id="PartFlat"
                                           class="btn-check" />
                                    <label for="PartFlat" style="margin-right:7px" class="btn btn-outline-primary">Доля</label>
                                </div>
                                <div class="col-md-auto" v-else-if="isResidentialPremises === 'ResidentialBuilding'">
                                    Типы жилых домов: Частный дом, Коттедж, Таунхаус, Дачный дом, Часть дома
                                </div>
                                <div class="col-md-auto" v-else></div>
                            </div>

                            <div class="row justify-content-end p-1">
                                <div class="col-md-auto">
                                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Закрыть</button>
                                </div>
                                <div class="col-md-auto">
                                    <button type="button" class="btn btn-success">Добавить объект</button>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <!-- Модальное окно -->

        </div>
        <div class="row mb-2">
            <table class="table table-hover text-nowrap" style="width:100%">
                <thead>
                    <tr>
                        <th></th>
                        <th>
                            Тип объекта
                        </th>
                        <th>
                            Назначение
                        </th>
                        <th>
                            Адрес
                        </th>
                        <th>Оцениваемые права</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td>Квартира</td>
                        <td>Жилое помещение</td>
                        <td>
                            <input type="text" class="form-control" />
                        </td>
                        <td>
                            <select style="width:100%" class="form-select">
                                <option value="1">Право собственности</option>
                                <option value="2">Право аренды</option>
                                <option value="3">Право требования</option>
                            </select>
                        </td>
                        <td>
                            <a class="btn btn-outline-danger">X</a>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class="row mb-2">
            <div class="col-lg-2 col-md-2">
                <label class="form-label">
                    Цель оценки
                </label>
            </div>
            <div class="col">
                <select class="form-select" style="width:100%">
                    <option value="1">Рыночная стоимость</option>
                    <option value="2">Рыночная и ликвидационная стоимость</option>
                    <option value="3">Ликвидационная стоимость</option>
                </select>
            </div>
        </div>
        <div class="row mb-2">
            <div class="col">
                <label class="form-label">
                    Предпосылки стоимости
                </label>
                <textarea class="form-control" rows="3"></textarea>
            </div>
            <div class="col">
                <label class="form-label">
                    Предполагаемое использование результатов оценки
                </label>
                <textarea class="form-control" rows="3"></textarea>
            </div>
        </div>
        <div class="row mb-2">
            <div class="col-md-3">
                <div class="btn-group" role="group">
                    <input type="radio" value="PrivatePerson" name="radioCastomer" v-model="isCustomer" id="PrivatePerson"
                           class="btn-check" />
                    <label for="PrivatePerson" class="btn btn-outline-primary">Частное лицо</label>
                    <input type="radio" value="Organization" name="radioCastomer" v-model="isCustomer" id="Organization"
                           class="btn-check" />
                    <label for="Organization" class="btn btn-outline-primary">Организация</label>
                </div>
            </div>
            <div class="col">
                <a class="btn btn-primary">Выбрать заказчика</a>
            </div>
        </div>
        <div class="row mb-2">
            <PrivatePersonComponent v-if="isCustomer === 'PrivatePerson'" />
            <OrganizationComponent v-else />
        </div>
        <div class="row text-center justify-content-md-center">

            <div class="col-lg-2">
                <a class="btn btn-outline-primary" style="width:100%">Назад</a>
            </div>
            <div class="col-md-auto"></div>
            <div class="col-lg-2">
                <a class="btn btn-primary" style="width:100%">Далее</a>
            </div>

        </div>
    </div>
</template>

<script>
    import OrganizationComponent from './organization-component'
    import PrivatePersonComponent from './privateperson-component'
    export default {
        name: 'evatask-component',
        data() {
            return {
                isCustomer: 'PrivatePerson',
                isRealEstate: '',
                isResidentialPremises: ''
            }
        },
        components:{
            OrganizationComponent,
            PrivatePersonComponent
            }
    }
</script>
